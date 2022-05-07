namespace wxCT4C;

public partial class cls_Files
{
    MainForm main;
    public cls_Files(MainForm main)
    {
        this.main = main;
    }
    internal void Read_Init()
    {
        StreamReader sr = new StreamReader("./wxCT4C.ini");
        while (!sr.EndOfStream)
        {
            Add_List(sr.ReadLine());
        }
        sr.Close();

        main.Draw_Main_Items();
    }
    private void Add_List(string? line)
    {
        string[] split = line!.Split(" : ");
        if (line == "" || split[1] == "") { return; }

        switch (split[0])
        {
            case "project_directory":
                main.project_directory = split[1];
                break;
            case "wxFormBuilder_project_file":
                main.wxFormBuilder_project_file = split[1];
                break;
            case "MinGW_directory":
                main.MinGW_directory = split[1];
                break;
            case "wxWidgets_directory":
                main.wxWidgets_directory = split[1];
                break;
            case "project_compilerflag_general":
                main.project_compilerflag_general.Add(split[1]);
                break;
            case "project_compilerflag_debugging":
                main.project_compilerflag_debugging.Add(split[1]);
                break;
            case "project_compilerflag_profilling":
                main.project_compilerflag_profilling.Add(split[1]);
                break;
            case "project_compilerflag_warning":
                main.project_compilerflag_warning.Add(split[1]);
                break;
            case "project_compilerflag_optimization":
                main.project_compilerflag_optimization.Add(split[1]);
                break;
            case "debug_compilerflag_general":
                main.debug_compilerflag_general.Add(split[1]);
                break;
            case "debug_compilerflag_debugging":
                main.debug_compilerflag_debugging.Add(split[1]);
                break;
            case "debug_compilerflag_profilling":
                main.debug_compilerflag_profilling.Add(split[1]);
                break;
            case "debug_compilerflag_warning":
                main.debug_compilerflag_warning.Add(split[1]);
                break;
            case "debug_compilerflag_optimization":
                main.debug_compilerflag_optimization.Add(split[1]);
                break;
            case "release_compilerflag_general":
                main.release_compilerflag_general.Add(split[1]);
                break;
            case "release_compilerflag_debugging":
                main.release_compilerflag_debugging.Add(split[1]);
                break;
            case "release_compilerflag_profilling":
                main.release_compilerflag_profilling.Add(split[1]);
                break;
            case "release_compilerflag_warning":
                main.release_compilerflag_warning.Add(split[1]);
                break;
            case "release_compilerflag_optimization":
                main.release_compilerflag_optimization.Add(split[1]);
                break;
            case "project_other_compile_options":
                main.project_other_compile_options.Add(split[1]);
                break;
            case "debug_other_compile_options":
                main.debug_other_compile_options.Add(split[1]);
                break;
            case "release_other_compile_options":
                main.release_other_compile_options.Add(split[1]);
                break;
            case "project_other_resource_compile_options":
                main.project_other_resource_compile_options.Add(split[1]);
                break;
            case "debug_other_resource_compile_options":
                main.debug_other_resource_compile_options.Add(split[1]);
                break;
            case "release_other_resource_compile_options":
                main.release_other_resource_compile_options.Add(split[1]);
                break;
            case "project_defines":
                main.project_defines.Add(split[1]);
                break;
            case "debug_defines":
                main.debug_defines.Add(split[1]);
                break;
            case "release_defines":
                main.release_defines.Add(split[1]);
                break;
            case "project_link_libraries":
                main.project_link_libraries.Add(split[1]);
                break;
            case "debug_link_libraries":
                main.debug_link_libraries.Add(split[1]);
                break;
            case "release_link_libraries":
                main.release_link_libraries.Add(split[1]);
                break;
            case "project_link_options":
                main.project_link_options.Add(split[1]);
                break;
            case "debug_link_options":
                main.debug_link_options.Add(split[1]);
                break;
            case "release_link_options":
                main.release_link_options.Add(split[1]);
                break;
            case "project_search_compiler_directory":
                main.project_search_compiler_directory.Add(split[1]);
                break;
            case "debug_search_compiler_directory":
                main.debug_search_compiler_directory.Add(split[1]);
                break;
            case "release_search_compiler_directory":
                main.release_search_compiler_directory.Add(split[1]);
                break;
            case "project_search_linker_directory":
                main.project_search_linker_directory.Add(split[1]);
                break;
            case "debug_search_linker_directory":
                main.debug_search_linker_directory.Add(split[1]);
                break;
            case "release_search_linker_directory":
                main.release_search_linker_directory.Add(split[1]);
                break;
            case "project_search_resource_compiler_directory":
                main.project_search_resource_compiler_directory.Add(split[1]);
                break;
            case "debug_search_resource_compiler_directory":
                main.debug_search_resource_compiler_directory.Add(split[1]);
                break;
            case "release_search_resource_compiler_directory":
                main.release_search_resource_compiler_directory.Add(split[1]);
                break;
        }
    }
    internal void Save()
    {
        string? write_Data = "";
        write_Data += Get_project_directory();
        write_Data += Get_wxFormBuilder_project_file();
        write_Data += Get_MinGW_directory();
        write_Data += Get_wxWidgets_directory();
        write_Data += Get_Compilerflag_General();
        write_Data += Get_Compilerflag_Debugging();
        write_Data += Get_Compilerflag_profilling();
        write_Data += Get_Compilerflag_Warnings();
        write_Data += Get_Compilerflag_Optimization();
        write_Data += Get_Other_Compiler_Options();
        write_Data += Get_Other_Resource_Compiler_Options();
        write_Data += Get_Defines();
        write_Data += Get_Linker_Libraries();
        write_Data += Get_Other_Link_Options();
        write_Data += Get_Search_Directories();

        StreamWriter sw = new StreamWriter("./wxCT4C.ini");
        sw.Write(write_Data);
        sw.Close();
    }
    private string Get_project_directory()
    {
        return "project_directory : " + main.project_directory + Environment.NewLine;
    }
    private string Get_wxFormBuilder_project_file()
    {
        return "wxFormBuilder_project_file : " + main.wxFormBuilder_project_file + Environment.NewLine;
    }
    private string Get_MinGW_directory()
    {
        return "MinGW_directory : " + main.MinGW_directory + Environment.NewLine;
    }
    private string Get_wxWidgets_directory()
    {
        return "wxWidgets_directory : " + main.wxWidgets_directory + Environment.NewLine;
    }
    private string Get_Compilerflag_General()
    {
        string? ret = "";
        for (int i = 0; i < main.project_compilerflag_general.Count; i++)
        {
            ret += "project_compilerflag_general : " + main.project_compilerflag_general[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.debug_compilerflag_general.Count; i++)
        {
            ret += "debug_compilerflag_general : " + main.debug_compilerflag_general[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.release_compilerflag_general.Count; i++)
        {
            ret += "release_compilerflag_general : " + main.release_compilerflag_general[i] + Environment.NewLine;
        }
        return ret;
    }
    private string Get_Compilerflag_Debugging()
    {
        string? ret = "";
        for (int i = 0; i < main.project_compilerflag_debugging.Count; i++)
        {
            ret += "project_compilerflag_debugging : " + main.project_compilerflag_debugging[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.debug_compilerflag_debugging.Count; i++)
        {
            ret += "debug_compilerflag_debugging : " + main.debug_compilerflag_debugging[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.release_compilerflag_debugging.Count; i++)
        {
            ret += "release_compilerflag_debugging : " + main.release_compilerflag_debugging[i] + Environment.NewLine;
        }
        return ret;
    }
    private string Get_Compilerflag_profilling()
    {
        string? ret = "";
        for (int i = 0; i < main.project_compilerflag_profilling.Count; i++)
        {
            ret += "project_compilerflag_profilling : " + main.project_compilerflag_profilling[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.debug_compilerflag_profilling.Count; i++)
        {
            ret += "debug_compilerflag_profilling : " + main.debug_compilerflag_profilling[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.release_compilerflag_profilling.Count; i++)
        {
            ret += "release_compilerflag_profilling : " + main.release_compilerflag_profilling[i] + Environment.NewLine;
        }
        return ret;
    }
    private string Get_Compilerflag_Warnings()
    {
        string? ret = "";
        for (int i = 0; i < main.project_compilerflag_warning.Count; i++)
        {
            ret += "project_compilerflag_warning : " + main.project_compilerflag_warning[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.debug_compilerflag_warning.Count; i++)
        {
            ret += "debug_compilerflag_warning : " + main.debug_compilerflag_warning[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.release_compilerflag_warning.Count; i++)
        {
            ret += "release_compilerflag_warning : " + main.release_compilerflag_warning[i] + Environment.NewLine;
        }
        return ret;
    }
    private string Get_Compilerflag_Optimization()
    {
        string? ret = "";
        for (int i = 0; i < main.project_compilerflag_optimization.Count; i++)
        {
            ret += "project_compilerflag_optimization : " + main.project_compilerflag_optimization[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.debug_compilerflag_optimization.Count; i++)
        {
            ret += "debug_compilerflag_optimization : " + main.debug_compilerflag_optimization[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.release_compilerflag_optimization.Count; i++)
        {
            ret += "release_compilerflag_optimization : " + main.release_compilerflag_optimization[i] + Environment.NewLine;
        }
        return ret;
    }
    private string Get_Other_Compiler_Options()
    {
        string? ret = "";
        for (int i = 0; i < main.project_other_compile_options.Count; i++)
        {
            ret += "project_other_compile_options : " + main.project_other_compile_options[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.debug_other_compile_options.Count; i++)
        {
            ret += "debug_other_compile_options : " + main.debug_other_compile_options[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.release_other_compile_options.Count; i++)
        {
            ret += "release_other_compile_options : " + main.release_other_compile_options[i] + Environment.NewLine;
        }
        return ret;
    }
    private string Get_Other_Resource_Compiler_Options()
    {
        string? ret = "";
        for (int i = 0; i < main.project_other_resource_compile_options.Count; i++)
        {
            ret += "project_other_resource_compile_options : " + main.project_other_resource_compile_options[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.debug_other_resource_compile_options.Count; i++)
        {
            ret += "debug_other_resource_compile_options : " + main.debug_other_resource_compile_options[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.release_other_resource_compile_options.Count; i++)
        {
            ret += "release_other_resource_compile_options : " + main.release_other_resource_compile_options[i] + Environment.NewLine;
        }
        return ret;
    }
    private string Get_Defines()
    {
        string? ret = "";
        for (int i = 0; i < main.project_defines.Count; i++)
        {
            ret += "project_defines : " + main.project_defines[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.debug_defines.Count; i++)
        {
            ret += "debug_defines : " + main.debug_defines[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.release_defines.Count; i++)
        {
            ret += "release_defines : " + main.release_defines[i] + Environment.NewLine;
        }
        return ret;
    }
    private string Get_Linker_Libraries()
    {
        string? ret = "";
        for (int i = 0; i < main.project_link_libraries.Count; i++)
        {
            ret += "project_link_libraries : " + main.project_link_libraries[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.debug_link_libraries.Count; i++)
        {
            ret += "debug_link_libraries : " + main.debug_link_libraries[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.release_link_libraries.Count; i++)
        {
            ret += "release_link_libraries : " + main.release_link_libraries[i] + Environment.NewLine;
        }
        return ret;
    }
    private string Get_Other_Link_Options()
    {
        string? ret = "";
        for (int i = 0; i < main.project_link_options.Count; i++)
        {
            ret += "project_link_options : " + main.project_link_options[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.debug_link_options.Count; i++)
        {
            ret += "debug_link_options : " + main.debug_link_options[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.release_link_options.Count; i++)
        {
            ret += "release_link_options : " + main.release_link_options[i] + Environment.NewLine;
        }
        return ret;
    }
    private string Get_Search_Directories()
    {
        string? ret = "";
        for (int i = 0; i < main.project_search_compiler_directory.Count; i++)
        {
            ret += "project_search_compiler_directory : " + main.project_search_compiler_directory[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.debug_search_compiler_directory.Count; i++)
        {
            ret += "debug_search_compiler_directory : " + main.debug_search_compiler_directory[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.release_search_compiler_directory.Count; i++)
        {
            ret += "release_search_compiler_directory : " + main.release_search_compiler_directory[i] + Environment.NewLine;
        }

        for (int i = 0; i < main.project_search_linker_directory.Count; i++)
        {
            ret += "project_search_linker_directory : " + main.project_search_linker_directory[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.debug_search_linker_directory.Count; i++)
        {
            ret += "debug_search_linker_directory : " + main.debug_search_linker_directory[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.release_search_linker_directory.Count; i++)
        {
            ret += "release_search_linker_directory : " + main.release_search_linker_directory[i] + Environment.NewLine;
        }

        for (int i = 0; i < main.project_search_resource_compiler_directory.Count; i++)
        {
            ret += "project_search_resource_compiler_directory : " + main.project_search_resource_compiler_directory[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.debug_search_resource_compiler_directory.Count; i++)
        {
            ret += "debug_search_resource_compiler_directory : " + main.debug_search_resource_compiler_directory[i] + Environment.NewLine;
        }
        for (int i = 0; i < main.release_search_resource_compiler_directory.Count; i++)
        {
            ret += "release_search_resource_compiler_directory : " + main.release_search_resource_compiler_directory[i] + Environment.NewLine;
        }
        return ret;
    }
    internal string Select_Dlg(string mode, string? item)
    {
        if (mode == "directory")
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select Directory";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.SelectedPath = Environment.CurrentDirectory;
            fbd.ShowNewFolderButton = true;

            if (fbd.ShowDialog(main) == DialogResult.OK)
            {
                item = fbd.SelectedPath.Replace("\\", "/");
            }
        }
        else if (mode == "file")
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = main.project_directory;
            ofd.Filter = "wxFormBuilder Project File(*.fbp;*.fbp)|*.fbp;*.fbp";
            ofd.Title = "Select File";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName.Replace("\\", "/");
            }
        }
        return item!;
    }
    internal List<string> Select_Dlg(string mode, List<string> item)
    {
        if (mode == "files")
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = main.project_directory;
            ofd.Multiselect = true;
            ofd.Filter = "Library Files(*.a;*.a)|*.a;*.a";
            ofd.Title = "Select Files";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                item.Clear();
                for (int i = 0; i < ofd.FileNames.Count(); i++)
                {
                    item.Add(ofd.FileNames[i].Replace("\\", "/"));
                }
            }
        }
        return item!;
    }
}