## 5.5 Using Files for Data Storage

### Three Steps of File Processing
1. **Open File:** Connects the file on disk to the program object.
2. **Process File:** Read data from or write data to the file.
3. **Close File:** Disconnects the file from the program to save resources and apply changes.

### File Types
* **Text Files:** Contains data encoded as text using schemes like ASCII or Unicode. Viewable with standard text editors.
* **Binary Files:** Contains unformatted binary data. Not human-readable with standard text editors.

### C# File Stream Classes (`System.IO`)

#### 1. Writing Data (`StreamWriter`)
* Used to create and write text to files.

Methods for opening/creating files via `File`:
* `File.CreateText("file.txt")`: Creates a new text file or overwrites an existing file.
* `File.AppendText("file.txt")`: Opens an existing text file to add data at the end without erasing content.

Methods on `StreamWriter`:
* `WriteLine()`: Writes a line of text followed by a newline character.
* `Write()`: Writes text without adding a newline character.

##### Example (Writing):
```csharp
StreamWriter outputFile;
outputFile = File.CreateText("courses.txt");
outputFile.WriteLine("Introduction to Computer Science");
outputFile.Close();
```

##### File Paths & Verbatim Strings:
Use `@` prefix for absolute path strings to avoid string escaping issues:
```csharp
StreamWriter outputFile = File.AppendText(@"C:\Data\Names.txt");
```

---

#### 2. Reading Data (`StreamReader`)
* Used to read characters or lines from text files.

Methods on `StreamReader`:
* `ReadLine()`: Reads the next line as a string.
* `Read()`: Reads the next character (returned as integer ASCII/Unicode value, often cast to `char`).
* `ReadToEnd()`: Reads all content from current position to end.
* `File.ReadAllText("file.txt")`: Utility method reading all contents at once into a single string.

##### Reading to End of Stream via Loop:
The `EndOfStream` Boolean property indicates if the end of the file has been reached.

```csharp
StreamReader inputFile = File.OpenText("students.txt");
while (!inputFile.EndOfStream)
{
    string line = inputFile.ReadLine();
    listBox1.Items.Add(line);
}
inputFile.Close();
```

---

## 5.6 OpenFileDialog and SaveFileDialog Controls

* Invisible controls in the Visual Studio Designer tray used to show standard Windows file dialog boxes.

### OpenFileDialog
* Displays the standard Windows **Open** dialog box.
* `ShowDialog()` returns a `DialogResult` (`DialogResult.OK` or `DialogResult.Cancel`).
* Selected path is available in the `.FileName` property.

#### Example:
```csharp
if (openFileDialog1.ShowDialog() == DialogResult.OK)
{
    StreamReader reader = File.OpenText(openFileDialog1.FileName);
    // Process file...
    reader.Close();
}
```

### SaveFileDialog
* Displays the standard Windows **Save As** dialog box.

#### Example:
```csharp
if (saveFileDialog1.ShowDialog() == DialogResult.OK)
{
    StreamWriter writer = File.CreateText(saveFileDialog1.FileName);
    writer.WriteLine("Data");
    writer.Close();
}
```

