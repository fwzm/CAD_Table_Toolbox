# CAD Table Tools (LISP)

## 1. 简介 (Introduction)
这是一个轻量级的 AutoCAD LISP 插件集合，旨在简化表格绘制和数据提取任务。它包含两个主要命令：一个用于快速生成标准网格表格，另一个用于将 CAD 中的文字内容按位置关系导出为 Excel 可读的 CSV 文件。

**适用版本**: AutoCAD 2018 及以上版本 (兼容大多数支持 AutoLISP 的 CAD 软件)

## 2. 功能列表 (Features)

### 命令 1: `QT_DRAW` (快速绘制表格)
*   **功能**: 根据用户输入的行数、列数、行高、列宽，自动绘制由直线组成的网格。
*   **输入**:
    *   行数 (Rows)
    *   列数 (Columns)
    *   行高 (Row Height)
    *   列宽 (Column Width)
    *   插入点 (Top-Left Insertion Point)
*   **输出**: 绘制在当前图层上的 LINE 实体。

### 命令 2: `QT_EXPORT` (导出文字到 CSV)
*   **功能**: 选择图纸中的文字 (TEXT 或 MTEXT)，程序会根据它们在图纸上的几何位置（从上到下，从左到右）自动排序，并保存为 CSV 表格文件。
*   **输入**: 框选包含文字的区域。
*   **输出**: 一个 `.csv` 文件，可以直接用 Excel 打开。
*   **智能排序**: 程序会自动识别同一行的文字（允许微小的Y轴误差），确保导出的表格结构正确。

## 3. 安装与加载 (Installation)
1.  下载 `TableTools.lsp` 文件到您的电脑。
2.  打开 AutoCAD。
3.  输入命令 `APPLOAD` 并回车。
4.  在弹出的对话框中，找到并选择 `TableTools.lsp`。
5.  点击“加载 (Load)”。
    *   *(可选) 将其拖入“启动组 (Startup Suite)”以在每次启动 CAD 时自动加载。*
6.  命令行提示 `>>> LISP Table Tools Loaded <<<` 即表示加载成功。

## 4. 使用说明 (Usage)

### 绘制表格
1.  输入命令 `QT_DRAW`。
2.  按提示输入行数、列数等参数（支持回车使用默认值）。
3.  在屏幕上点击一点作为表格的左上角。

### 导出文字
1.  输入命令 `QT_EXPORT`。
2.  框选您想要导出的文字对象。
3.  在弹出的保存对话框中，选择 CSV 文件的保存位置。
4.  导出完成后，程序会尝试自动打开该文件。

## 5. 已知限制 (Limitations)
*   **QT_EXPORT**: 仅支持单行文字 (TEXT) 和多行文字 (MTEXT)，不支持块属性或表格实体 (ACAD_TABLE)。
*   **排序精度**: 默认使用文字高度的 50% 作为“行对齐容差”。如果表格行非常密集且文字未严格对齐，可能会导致行识别错误。

## 6. 作者与许可 (Author & License)
*   **Author**: CAD Pair Programmer
*   **License**: MIT License
