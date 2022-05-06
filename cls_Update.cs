namespace wxCT4C;

public partial class cls_Update
{
    MainForm main;
    public cls_Update(MainForm main)
    {
        this.main = main;
    }
    internal void Update_Compiler_Flag_General(string mode, CheckedListBox ChkLstBox)
    {
        List<string> lst_compilerflag_general = new();

        for (int i = 0; i < ChkLstBox.Items.Count; i++)
        {
            if (ChkLstBox.GetItemChecked(i))
            {
                string[] split = ChkLstBox.Items[i].ToString()!.Split("[");
                string? value = split[1].Replace("]", "");
                lst_compilerflag_general.Add(value);
            }
        }

        switch (mode)
        {
            case "Project":
                main.project_compilerflag_general = lst_compilerflag_general;
                break;
            case "Debug":
                main.debug_compilerflag_general = lst_compilerflag_general;
                break;
            case "Release":
                main.release_compilerflag_general = lst_compilerflag_general;
                break;
        }
    }
    internal void Update_Compiler_Flag_Debugging(string mode, CheckedListBox ChkLstBox)
    {
        List<string> lst_compilerflag_debugging = new();

        for (int i = 0; i < ChkLstBox.Items.Count; i++)
        {
            if (ChkLstBox.GetItemChecked(i))
            {
                string[] split = ChkLstBox.Items[i].ToString()!.Split("[");
                string? value = split[1].Replace("]", "");
                lst_compilerflag_debugging.Add(value);
            }
        }

        switch (mode)
        {
            case "Project":
                main.project_compilerflag_debugging = lst_compilerflag_debugging;
                break;
            case "Debug":
                main.debug_compilerflag_debugging = lst_compilerflag_debugging;
                break;
            case "Release":
                main.release_compilerflag_debugging = lst_compilerflag_debugging;
                break;
        }
    }
    internal void Update_Compiler_Flag_Profilling(string mode, CheckedListBox ChkLstBox)
    {
        List<string> lst_compilerflag_profilling = new();

        for (int i = 0; i < ChkLstBox.Items.Count; i++)
        {
            if (ChkLstBox.GetItemChecked(i))
            {
                string[] split = ChkLstBox.Items[i].ToString()!.Split("[");
                string? value = split[1].Replace("]", "");
                lst_compilerflag_profilling.Add(value);
            }
        }

        switch (mode)
        {
            case "Project":
                main.project_compilerflag_profilling = lst_compilerflag_profilling;
                break;
            case "Debug":
                main.debug_compilerflag_profilling = lst_compilerflag_profilling;
                break;
            case "Release":
                main.release_compilerflag_profilling = lst_compilerflag_profilling;
                break;
        }
    }
    internal void Update_Compiler_Flag_Warnings(string mode, CheckedListBox ChkLstBox)
    {
        List<string> lst_compilerflag_warnings = new();

        for (int i = 0; i < ChkLstBox.Items.Count; i++)
        {
            if (ChkLstBox.GetItemChecked(i))
            {
                string[] split = ChkLstBox.Items[i].ToString()!.Split("[");
                string? value = split[1].Replace("]", "");
                lst_compilerflag_warnings.Add(value);
            }
        }

        switch (mode)
        {
            case "Project":
                main.project_compilerflag_warning = lst_compilerflag_warnings;
                break;
            case "Debug":
                main.debug_compilerflag_warning = lst_compilerflag_warnings;
                break;
            case "Release":
                main.release_compilerflag_warning = lst_compilerflag_warnings;
                break;
        }
    }
    internal void Update_Compiler_Flag_Optimization(string mode, CheckedListBox ChkLstBox)
    {
        List<string> lst_compilerflag_optimization = new();

        for (int i = 0; i < ChkLstBox.Items.Count; i++)
        {
            if (ChkLstBox.GetItemChecked(i))
            {
                string[] split = ChkLstBox.Items[i].ToString()!.Split("[");
                string? value = split[1].Replace("]", "");
                lst_compilerflag_optimization.Add(value);
            }
        }

        switch (mode)
        {
            case "Project":
                main.project_compilerflag_optimization = lst_compilerflag_optimization;
                break;
            case "Debug":
                main.debug_compilerflag_optimization = lst_compilerflag_optimization;
                break;
            case "Release":
                main.release_compilerflag_optimization = lst_compilerflag_optimization;
                break;
        }
    }
    internal void Update_Other_Compiler_Options(string mode, TextBox TxtBox)
    {
        List<string> lst_other_compiler_options = new();
        string[] split = TxtBox.Text.Split(Environment.NewLine);

        for (int i = 0; i < split.Count(); i++)
        {
            if (split[i] != "")
            {
                lst_other_compiler_options.Add(split[i]);
            }
        }

        switch (mode)
        {
            case "Project":
                main.project_other_compile_options = lst_other_compiler_options;
                break;
            case "Debug":
                main.debug_other_compile_options = lst_other_compiler_options;
                break;
            case "Release":
                main.release_other_compile_options = lst_other_compiler_options;
                break;
        }
    }
    internal void Update_Other_Resource_Compiler_Options(string mode, TextBox TxtBox)
    {
        List<string> lst_other_resource_compiler_options = new();
        string[] split = TxtBox.Text.Split(Environment.NewLine);

        for (int i = 0; i < split.Count(); i++)
        {
            if (split[i] != "")
            {
                lst_other_resource_compiler_options.Add(split[i]);
            }
        }

        switch (mode)
        {
            case "Project":
                main.project_other_resource_compile_options = lst_other_resource_compiler_options;
                break;
            case "Debug":
                main.debug_other_resource_compile_options = lst_other_resource_compiler_options;
                break;
            case "Release":
                main.release_other_resource_compile_options = lst_other_resource_compiler_options;
                break;
        }
    }
    internal void Update_Defines(string mode, TextBox TxtBox)
    {
        List<string> lst_defines = new();
        string[] split = TxtBox.Text.Split(Environment.NewLine);

        for (int i = 0; i < split.Count(); i++)
        {
            if (split[i] != "")
            {
                lst_defines.Add(split[i]);
            }
        }

        switch (mode)
        {
            case "Project":
                main.project_defines = lst_defines;
                break;
            case "Debug":
                main.debug_defines = lst_defines;
                break;
            case "Release":
                main.release_defines = lst_defines;
                break;
        }
    }
    internal void Update_Link_Settings(string mode, ListBox LstBox, TextBox TxtBox)
    {
        List<string> lst_link_libraries = new();
        List<string> lst_link_options = new();

        for (int i = 0; i < LstBox.Items.Count; i++)
        {
            lst_link_libraries.Add(LstBox.Items[i].ToString()!);
        }

        string[] split = TxtBox.Text.Split(Environment.NewLine);

        for (int i = 0; i < split.Count(); i++)
        {
            if (split[i] != "")
            {
                lst_link_options.Add(split[i]);
            }
        }

        switch (mode)
        {
            case "Project":
                main.project_link_libraries = lst_link_libraries;
                main.project_link_options = lst_link_options;
                break;
            case "Debug":
                main.debug_link_libraries = lst_link_libraries;
                main.debug_link_options = lst_link_options;
                break;
            case "Release":
                main.release_link_libraries = lst_link_libraries;
                main.release_link_options = lst_link_options;
                break;
        }
    }
    internal void Update_Search_Directories_Compiler(string mode, ListBox LstBox)
    {
        List<string> lst_search_compiler_directory = new();

        for (int i = 0; i < LstBox.Items.Count; i++)
        {
            lst_search_compiler_directory.Add(LstBox.Items[i].ToString()!);
        }

        switch (mode)
        {
            case "Project":
                main.project_search_compiler_directory = lst_search_compiler_directory;
                break;
            case "Debug":
                main.debug_search_compiler_directory = lst_search_compiler_directory;
                break;
            case "Release":
                main.release_search_compiler_directory = lst_search_compiler_directory;
                break;
        }
    }
    internal void Update_Search_Directories_Linker(string mode, ListBox LstBox)
    {
        List<string> lst_search_linker_directory = new();

        for (int i = 0; i < LstBox.Items.Count; i++)
        {
            lst_search_linker_directory.Add(LstBox.Items[i].ToString()!);
        }

        switch (mode)
        {
            case "Project":
                main.project_search_linker_directory = lst_search_linker_directory;
                break;
            case "Debug":
                main.debug_search_linker_directory = lst_search_linker_directory;
                break;
            case "Release":
                main.release_search_linker_directory = lst_search_linker_directory;
                break;
        }
    }
    internal void Update_Search_Directories_Resource_Compiler(string mode, ListBox LstBox)
    {
        List<string> lst_search_resource_compiler_directory = new();

        for (int i = 0; i < LstBox.Items.Count; i++)
        {
            lst_search_resource_compiler_directory.Add(LstBox.Items[i].ToString()!);
        }

        switch (mode)
        {
            case "Project":
                main.project_search_resource_compiler_directory = lst_search_resource_compiler_directory;
                break;
            case "Debug":
                main.debug_search_resource_compiler_directory = lst_search_resource_compiler_directory;
                break;
            case "Release":
                main.release_search_resource_compiler_directory = lst_search_resource_compiler_directory;
                break;
        }
    }

}