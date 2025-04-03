# What This is
Windows application used to simulate key press, written in C# .NET Framework.
When the simulation is on, only the active window receives the input.

**Important** - Please read the "Known Issue" section below.

# Terms
1. _Action_ - The action to simulate (e.g.: _Press "A"_, _Delay 1s_, and _Hold "D" 0.5s_).

![Action](./Keyboard%20Macro/docs/Images/Action.png)
2. _Repeat Times_ - How many times all actions in the table are repeated (Can be infinite, or finite).

![Repeat Times](./Keyboard%20Macro/docs/Images/Repeat%20Times.png)

3. _Loop Interval_ - Amount of time to wait before the next repetition starts.

![Loop Interval](./Keyboard%20Macro/docs/Images/Loop%20Interval.png)

In this image, the simulation works like this: Press "A", delay 1s, hold "D" 0.5s, wait _Loop Interval_ 0.1s, repeat infinitely

4. _Simulation_ - Information about: All _Actions_, _Repeat Times_, _Loop Interval_, and the application to simulate key presses on. A _Simulation_ can be saved as a file so it can be loaded in the future.

# How to Use
## A. Settings
![Settings](./Keyboard%20Macro/docs/Images/Settings.png)

1. Select which application to simulate key press on by clicking the "Set" button on the right.
2. Set _Repeat Times_ and _Loop Interval_

## B. Action Settings
![Action Settings](./Keyboard%20Macro/docs/Images/Action%20Settings.png)

### 1. Add _Action_
Click the "Add" button. A new window will open up.

![Add Action](./Keyboard%20Macro/docs/Images/Set%20Action.png)

Select whether to press/hold key, or to delay. Click "Set", and another window will open.

![Set Key](/Keyboard%20Macro/docs/Images/Set%20Key.png)

Press *any key we want to simulate. "Duration" determines how long the key is held down or how long the delay lasts.

*Not all keys are supported in order to prevent bugs. Some keys such as Esc, Alt, Ctrl, Shift, and Insert cannot be simulated.

### 2. Edit/Delete _Action_
First, select the _Action_ we want edited/deleted in the table by clicking it.

![Select Action](./Keyboard%20Macro/docs/Images/Select%20Action.png)

In this image, the delay _Action_ has been selected.
To edit, click the "Edit" button, then the same window for adding _Action_ will open.
To delete, click the "Delete" button, and we will be prompted to confirm deletion.
The "Clear" button deletes all _Actions_ in the table.

### 3. Sorting _Action_
The arrow buttons are used to change the order of the selected _Action_

![Sort Action](./Keyboard%20Macro/docs/Images/Sort%20Action.png)

In this image, the selected _Action_ (delay 1s) has been moved up after clicking the up arrow button.

### 4. Save/Load _Simulation_
Clicking the "Save" button will allow us to save the _Simulation_ (_Actions_, _Repeat Times_, _Loop Interval_, and application) to a file.
This file can be loaded by clicking the "Load" button.
This way, we can switch between multiple _Simulations_ easily.

![Load Simulation](./Keyboard%20Macro/docs/Images/Load%20Simulation.png)

Test.xml next to the application name indicates that we loaded the Test.xml simulation file.

When this application is closed, the current _Simulation_ is automatically saved as .temp.xml.
When this application is opened, it will automatically load .temp.xml if available.
This way, we don't need to manually select the previous _Simulation_ that we loaded over and over.

## C. Play/Stop _Simulation_
![Play Simulation](./Keyboard%20Macro/docs/Images/Play%20Simulation.png)

When clicking the "Play" button, the _Simulation_ will start running.
When the _Simulation_ is running, the "Play" button changes to "Stop" button.
Clicking the "Stop" button will stop the simulation.

Alternatively, a hotkey can be set to substitute clicking the button.
**Important** - Please read the "Known Issue" section below.

# Known Issue
Currently, there's an issue with the "Stop" button.
If the delay between _Actions_ or the _Loop Interval_ is too short, the "Stop" button will not be responsive.
**However, stopping the _Simulation_ with hotkey will work completely fine.**
So, please set a hotkey for the Play/Stop button.
