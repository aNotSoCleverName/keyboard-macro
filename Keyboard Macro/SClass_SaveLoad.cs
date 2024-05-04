using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Keyboard_Macro
{
    static public class SClass_SaveLoad
    {
        static string _currentPath = AppDomain.CurrentDomain.BaseDirectory + "Projects\\";
        static string _currentFile = "";

        public static void Save(string inFilePath, 
                                string inProcessName, string inWindowTitle, 
                                bool inIsRepeatFinite, decimal inRepeatTimes,
                                decimal inLoopIntervalInSec)
        {
            // Create an XmlWriter to write XML to a file
            using (XmlWriter writer = XmlWriter.Create(inFilePath, writerSettings))
            {
                // Start writing the XML content
                writer.WriteStartDocument();
                writer.WriteStartElement(xmlRoot);

                // Write process/window
                {
                    writer.WriteStartElement(xmlProcess);
                    writer.WriteAttributeString(xmlProcessName, inProcessName);
                    writer.WriteAttributeString(xmlWindowName, inWindowTitle);
                    writer.WriteEndElement();
                }

                // Write repeat type
                {
                    writer.WriteStartElement(xmlRepeat);

                    // Find and write repeat type
                    {
                        string repeatType = xmlInfinite;
                        if (inIsRepeatFinite)
                            repeatType = xmlFinite;

                        writer.WriteAttributeString(xmlRepeatType, repeatType);
                    }

                    writer.WriteAttributeString(xmlRepeatAmount, inRepeatTimes.ToString());

                    writer.WriteEndElement();
                }

                // Write loop
                {
                    writer.WriteStartElement(xmlLoop);
                    writer.WriteAttributeString(xmlLoopInterval, inLoopIntervalInSec.ToString());
                    writer.WriteEndElement();
                }

                // Write actions
                {
                    writer.WriteStartElement(xmlActions);
                    foreach (Class_Action keyAction in Class_Action.KeyActions)
                    {
                        writer.WriteStartElement(xmlAction);
                        writer.WriteAttributeString(xmlType, keyAction.ActionType);
                        writer.WriteAttributeString(xmlKey, keyAction.Key);
                        writer.WriteAttributeString(xmlDuration, keyAction.Duration);
                        writer.WriteAttributeString(xmlStrVk, keyAction.StrVk);
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();   // End root
                writer.WriteEndDocument();

                writer.Flush();
            }
        }

        public static void Load(string inFilePath,
                                TextBox inTb_ProcessName, TextBox inTb_WindowTitle,
                                RadioButton inRb_RepeatInfinite, RadioButton inRb_RepeatFinite, NumericUpDown inNud_RepeatFinite,
                                NumericUpDown inNud_LoopInterval,
                                DataGridView inDgv_Action)
        {
            using (XmlReader reader = XmlReader.Create(inFilePath, readerSettings))
            {
                while (reader.Read())
                {
                    switch (reader.Name)
                    {
                        case xmlProcess:
                            inTb_ProcessName.Text = reader.GetAttribute(xmlProcessName);
                            inTb_WindowTitle.Text = reader.GetAttribute(xmlWindowName);
                            break;

                        case xmlRepeat:
                            string repeatType = reader.GetAttribute(xmlRepeatType);

                            if (repeatType.Equals(xmlInfinite))
                            {
                                inRb_RepeatInfinite.Checked = true;
                                break;
                            }

                            inRb_RepeatFinite.Checked = true;
                            inNud_RepeatFinite.Value = Decimal.Parse(reader.GetAttribute(xmlRepeatAmount));
                            break;

                        case xmlLoop:
                            inNud_LoopInterval.Value = Decimal.Parse(reader.GetAttribute(xmlLoopInterval));
                            break;

                        case xmlAction:
                            Class_Action newAction = new Class_Action(reader.GetAttribute(xmlType),
                                                                      reader.GetAttribute(xmlKey),
                                                                      reader.GetAttribute(xmlStrVk),
                                                                      reader.GetAttribute(xmlDuration));

                            //Add action to list
                            Class_Action.KeyActions.Add(newAction);

                            //Add action to DGV
                            {
                                DataGridViewRow newRow = new DataGridViewRow();
                                newRow.CreateCells(inDgv_Action);

                                newRow.Cells[0].Value = newAction.ActionType;
                                newRow.Cells[1].Value = newAction.Key;
                                newRow.Cells[2].Value = newAction.Duration;
                                newRow.Cells[3].Value = newAction.StrVk;

                                newAction.ActionToRow(newRow);
                                inDgv_Action.Rows.Add(newRow);
                            }
                            break;
                    }
                }
            }
        }

        private static XmlWriterSettings writerSettings = new XmlWriterSettings
        {
            Indent = true,  // Enable indentation for readability
            IndentChars = "    ",  // Set the indentation characters
            NewLineChars = "\r\n",  // Set the newline characters
            NewLineHandling = NewLineHandling.Replace  // Replace the default newline handling
        };

        private static XmlReaderSettings readerSettings = new XmlReaderSettings
        {
            IgnoreWhitespace = true,
            IgnoreComments = true,
        };

        // Strings for xml element and attribute
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
        const string xmlStrVk = "StrVk";
        const string xmlDuration = "Duration";

        //Get set
        public static string CurrentPath { get => _currentPath; set => _currentPath = value; }
        public static string CurrentFile { get => _currentFile; set => _currentFile = value; }
    }
}
