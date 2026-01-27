# CAD Table Toolbox Plugin Implementation Plan

Based on your requirements and the provided screenshots, I will build a comprehensive AutoCAD plugin (C# .NET) that includes table generation, import, conversion, and editing capabilities.

## 1. Project Initialization
- **Framework**: .NET Framework 4.8 (Standard for modern AutoCAD versions).
- **Structure**: Class Library project (`CAD_Table_Toolbox`).
- **Dependencies**: References to `AcMgd.dll`, `AcDbMgd.dll`, `AcCoreMgd.dll`, and `Microsoft.Office.Interop.Excel`.

## 2. User Interface (WinForms)
I will create two main forms matching your screenshots:
- **`MainForm.cs` (Table Toolbox V4.0)**:
  - **Table Generation**: Inputs for rows, columns, row height, column width, border settings, and layer selection.
  - **Table Import**: Buttons for "Import Excel" and "Link Excel".
  - **Table Conversion**: Buttons for "Line Table to Table" and "Export Line Table to Excel".
  - **Table Editing**: Buttons for "Batch Align" and "Auto Adjust Row/Col".
- **`ImportForm.cs` (Excel Import to CAD)**:
  - Range selection (All cells vs Selected).
  - File selection.
  - Text height settings (Excel size vs Fixed height).
  - Layer/Color settings.

## 3. Core Functionality Implementation
- **Command Registration**: Define the `TableToolbox` command to launch the plugin.
- **Table Generation Module**:
  - Logic to draw native CAD `Table` entities or "Fake" tables (Lines + Text) based on user settings.
- **Excel Integration Module**:
  - **Import**: Read Excel data and populate CAD tables.
  - **Export**: Parse CAD selection and write to a new Excel file.
  - **Linking (Bi-directional)**:
    - Store Excel file path and range hash in the CAD Table's XData.
    - Implement a mechanism (command or event) to check for updates.
- **Conversion Algorithms**:
  - **Line Table -> CAD Table**: Geometric analysis to find grid intersections, identify cells, and move text content into a new CAD Table entity.
  - **Text Alignment**: Algorithm to center-align text within the bounding box of surrounding lines.

## 4. File Structure
- `CAD_Table_Toolbox.csproj`: Project configuration.
- `Plugin.cs`: Entry point and command definitions.
- `MainForm.cs` & `MainForm.Designer.cs`: Main UI.
- `ImportForm.cs` & `ImportForm.Designer.cs`: Import Settings UI.
- `TableEngine.cs`: Core logic for creating and manipulating CAD tables.
- `ExcelEngine.cs`: Logic for Excel COM Interop.
- `ConversionEngine.cs`: Logic for Line-to-Table conversion.

I will start by creating the project structure and the UI code, followed by the implementation of the logic classes.