# CAD Table Toolbox Plugin V4.0 - Installation Guide

## 1. 编译项目 (Build Project)
由于这是一个 C# .NET 插件，您需要先将其编译为 DLL 文件。

1. **打开项目**: 使用 **Visual Studio 2019** 或更高版本打开 `CAD_Table_Toolbox.csproj` 文件。
2. **修复引用 (References)**:
   - 在 Visual Studio 的“解决方案资源管理器 (Solution Explorer)”中，展开 **References**。
   - 如果看到 `AcCoreMgd`, `AcDbMgd`, `AcMgd` 有黄色感叹号，说明路径不对。
   - 右键点击这些引用 -> **Remove (移除)**。
   - 右键点击 **References** -> **Add Reference (添加引用)**。
   - 点击 **Browse (浏览)**，找到您的 AutoCAD 安装目录 (例如 `C:\Program Files\Autodesk\AutoCAD 202X\`)。
   - 选择以下三个文件并添加:
     - `AcCoreMgd.dll`
     - `AcDbMgd.dll`
     - `AcMgd.dll`
   - *注意: 还要确保 `Copy Local` 属性设置为 `False`。*
3. **编译**: 点击菜单栏的 **Build (生成)** -> **Build Solution (生成解决方案)**。
   - 编译成功后，DLL 文件会在项目目录的 `bin\Debug\` 或 `bin\Release\` 文件夹下，文件名为 `CAD_Table_Toolbox.dll`。

## 2. 加载到 AutoCAD (Load Plugin)

1. 打开 AutoCAD。
2. 在命令行输入 **`NETLOAD`** 并回车。
3. 在弹出的文件选择窗口中，找到并选择刚才编译好的 `CAD_Table_Toolbox.dll` 文件。
4. 点击“打开”。

## 3. 使用插件 (Usage)

加载成功后，在 AutoCAD 命令行输入以下命令即可启动工具箱：

- **命令**: `TableToolbox`

这将打开“表格工具箱 V4.0”的主界面。

## 4. 功能说明

- **表格生成**: 设置行列数和图层，点击“生成表格”并在图中指定插入点。
- **Excel 导入/链接**:
  - **导入**: 将 Excel 数据一次性导入为 CAD 表格。
  - **链接**: 导入并建立链接，后续可通过代码扩展实现双向更新。
- **表格转换**: (需要根据实际图形调整算法) 选择线条和文字转换为 CAD 表格实体。
