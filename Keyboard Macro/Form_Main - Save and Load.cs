using Keyboard_Macro.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Keyboard_Macro
{
    public partial class Form_Main : Form
    {
        static string _currentPath = AppDomain.CurrentDomain.BaseDirectory + "Projects\\";
        static string _currentFile = "";

        private void btn_SaveActions_Click(object sender, EventArgs e)
        {
            // Restore dialog init directory
            this.saveFileDialog1.InitialDirectory = CurrentPath;

            // Cancel save
            if (this.saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            // Set dialog init directory
            CurrentPath = this.saveFileDialog1.InitialDirectory;

            // Create an XmlWriter to write XML to a file
            using (XmlWriter writer = XmlWriter.Create(this.saveFileDialog1.FileName, this.writerSettings))
            {
                // Start writing the XML content
                writer.WriteStartDocument();
                writer.WriteStartElement(Form_Main.xmlRoot);

                // Write process/window
                if (selectedProcess != null)
                {
                    writer.WriteStartElement(Form_Main.xmlProcess);    
                    writer.WriteAttributeString(Form_Main.xmlProcessName, this.selectedProcess.ProcessName);
                    writer.WriteAttributeString(Form_Main.xmlWindowName, this.selectedProcess.MainWindowTitle);
                    writer.WriteEndElement();
                }

                // Write repeat type
                {
                    writer.WriteStartElement(Form_Main.xmlRepeat);

                    // Find and write repeat type
                    {
                        string repeatType = xmlInfinite;
                        if (rb_RepeatXTimes.Checked)
                            repeatType = xmlFinite;

                        writer.WriteAttributeString(Form_Main.xmlRepeatType, repeatType);
                    }

                    writer.WriteAttributeString(Form_Main.xmlRepeatAmount, nud_RepeatXTimes.Value.ToString());

                    writer.WriteEndElement();
                }

                // Write loop
                {
                    writer.WriteStartElement(xmlLoop);
                    writer.WriteAttributeString(xmlLoopInterval, nud_LoopInterval.Value.ToString());
                    writer.WriteEndElement();
                }

                // Write actions
                {
                    writer.WriteStartElement(xmlActions);
                    foreach (Class_Action keyAction in Class_Action.KeyActions)
                    {
                        writer.WriteStartElement(Form_Main.xmlAction);
                        writer.WriteAttributeString(Form_Main.xmlType, keyAction.ActionType);
                        writer.WriteAttributeString(Form_Main.xmlKey, keyAction.Key);
                        writer.WriteAttributeString(Form_Main.xmlDuration, keyAction.Duration);
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();   // End root
                writer.WriteEndDocument();

                writer.Flush();
            }
        }

        private void btn_LoadActions_Click(object sender, EventArgs e)
        {
            // Restore dialog init directory
            this.openFileDialog1.InitialDirectory = CurrentPath;

            // Cancel load
            if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            // Set dialog init directory
            CurrentPath = this.openFileDialog1.InitialDirectory;

            // Cancel load if not clear actions
            if (!this.ClearActions())
                return;

            using (XmlReader reader = XmlReader.Create(this.openFileDialog1.FileName, this.readerSettings))
            {
                while (reader.Read())
                {
                    switch(reader.Name)
                    {
                        case xmlProcess:
                            this.tb_ProcessName.Text = reader.GetAttribute(Form_Main.xmlProcessName);
                            this.tb_WindowTitle.Text = reader.GetAttribute(Form_Main.xmlWindowName);

                            Process[] list_Process = Process.GetProcesses();
                            this.selectedProcess = list_Process.FirstOrDefault(process => process.MainWindowTitle.Equals(tb_WindowTitle.Text));
                            break;

                        case xmlRepeat:
                            string repeatType = reader.GetAttribute(Form_Main.xmlRepeatType);
                            Console.WriteLine(repeatType);
                            if (repeatType.Equals(xmlInfinite))
                            {
                                rb_RepeatInfinite.Checked = true;
                                break;
                            }

                            rb_RepeatXTimes.Checked = true;
                            nud_RepeatXTimes.Value = Decimal.Parse(reader.GetAttribute(Form_Main.xmlRepeatAmount));
                            break;

                        case xmlLoop:
                            nud_LoopInterval.Value = Decimal.Parse(reader.GetAttribute(Form_Main.xmlLoopInterval));
                            break;

                        case xmlAction:
                            Class_Action newAction = new Class_Action(reader.GetAttribute(Form_Main.xmlType),
                                                              reader.GetAttribute(Form_Main.xmlKey),
                                                              reader.GetAttribute(Form_Main.xmlDuration));

                            //Add action to list
                            Class_Action.KeyActions.Add(newAction);

                            //Add action to DGV
                            {
                                DataGridViewRow newRow = new DataGridViewRow();
                                newRow.CreateCells(this.dgv_Action);

                                newRow.Cells[0].Value = newAction.ActionType;
                                newRow.Cells[1].Value = newAction.Key;
                                newRow.Cells[2].Value = newAction.Duration;

                                newAction.CleanActionRow(newRow);
                                this.dgv_Action.Rows.Add(newRow);
                            }
                            break;
                    }
                }
            }
        }

        const string xmlRoot = "Root";

        const string xmlProcess = "Process";
        const string xmlProcessName = "ProcessName";
        const string xmlWindowName = "WindowName";

        const string xmlRepeat = "Repeat";
        const string xmlRepeatType = "RepeatType";
        const string xmlInfinite = "Infinite";
        const string xmlFinite = "Finite";
        const string xmlRepeatAmount = "RepeatAmount";

        const string xmlLoop = "Loop";
        const string xmlLoopInterval = "LoopInterval";

        const string xmlActions = "Actions";
        const string xmlAction = "Action";
        const string xmlType = "ActionType";
        const string xmlKey = "Key";
        const string xmlDuration = "Duration";

        private XmlWriterSettings writerSettings = new XmlWriterSettings
        {
            Indent = true,  // Enable indentation for readability
            IndentChars = "    ",  // Set the indentation characters
            NewLineChars = "\r\n",  // Set the newline characters
            NewLineHandling = NewLineHandling.Replace  // Replace the default newline handling
        };

        private XmlReaderSettings readerSettings = new XmlReaderSettings
        {
            IgnoreWhitespace = true,
            IgnoreComments = true,
        };

        //Get set
        public static string CurrentPath { get => _currentPath; set => _currentPath = value; }
        public static string CurrentFile { get => _currentFile; set => _currentFile = value; }
    }
}
