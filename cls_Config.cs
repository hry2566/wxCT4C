namespace wxCT4C;

public partial class cls_Config
{
    MainForm main;
    public cls_Config(MainForm main)
    {
        this.main = main;
    }
    internal string Write_Config(string line)
    {
        string dummy = line;
        line = "";

        if (dummy.IndexOf("{MinGW_directory}") > -1)
        {
            line = dummy.Replace("{MinGW_directory}", main.MinGW_directory!.Replace("\\", "/")) + "\n";
        }
        else if (dummy.IndexOf("{wxWidgets_directory}") > -1)
        {
            line = dummy.Replace("{wxWidgets_directory}", main.wxWidgets_directory!.Replace("\\", "/")) + "\n";
        }

        else if (dummy.IndexOf("{project_search_compiler_directory}") > -1)
        {
            for (int i = 0; i < main.project_search_compiler_directory.Count; i++)
            {
                line += dummy.Replace("{project_search_compiler_directory}", main.project_search_compiler_directory[i].Replace("\\", "/")) + "\n";
            }
        }
        else if (dummy.IndexOf("{debug_search_compiler_directory}") > -1)
        {
            for (int i = 0; i < main.debug_search_compiler_directory.Count; i++)
            {
                line += dummy.Replace("{debug_search_compiler_directory}", main.debug_search_compiler_directory[i].Replace("\\", "/")) + "\n";
            }
        }
        else if (dummy.IndexOf("{release_search_compiler_directory}") > -1)
        {
            for (int i = 0; i < main.release_search_compiler_directory.Count; i++)
            {
                line += dummy.Replace("{release_search_compiler_directory}", main.release_search_compiler_directory[i].Replace("\\", "/")) + "\n";
            }
        }

        else if (dummy.IndexOf("{project_other_compile_options}") > -1)
        {
            for (int i = 0; i < main.project_other_compile_options.Count; i++)
            {
                line += dummy.Replace("{project_other_compile_options}", main.project_other_compile_options[i]) + "\n";
            }
        }
        else if (dummy.IndexOf("{debug_other_compile_options}") > -1)
        {
            for (int i = 0; i < main.debug_other_compile_options.Count; i++)
            {
                line += dummy.Replace("{debug_other_compile_options}", main.debug_other_compile_options[i]) + "\n";
            }
        }
        else if (dummy.IndexOf("{release_other_compile_options}") > -1)
        {
            for (int i = 0; i < main.release_other_compile_options.Count; i++)
            {
                line += dummy.Replace("{release_other_compile_options}", main.release_other_compile_options[i]) + "\n";
            }
        }

        else if (dummy.IndexOf("{project_defines}") > -1)
        {
            for (int i = 0; i < main.project_defines.Count; i++)
            {
                line += dummy.Replace("{project_defines}", main.project_defines[i]) + "\n";
            }
        }
        else if (dummy.IndexOf("{debug_defines}") > -1)
        {
            for (int i = 0; i < main.debug_defines.Count; i++)
            {
                line += dummy.Replace("{debug_defines}", main.debug_defines[i]) + "\n";
            }
        }
        else if (dummy.IndexOf("{release_defines}") > -1)
        {
            for (int i = 0; i < main.release_defines.Count; i++)
            {
                line += dummy.Replace("{release_defines}", main.release_defines[i]) + "\n";
            }
        }

        else if (dummy.IndexOf("{project_compilerflag_warning}") > -1)
        {
            for (int i = 0; i < main.project_compilerflag_warning.Count; i++)
            {
                line += dummy.Replace("{project_compilerflag_warning}", main.project_compilerflag_warning[i]) + "\n";
            }
        }
        else if (dummy.IndexOf("{debug_compilerflag_warning}") > -1)
        {
            for (int i = 0; i < main.debug_compilerflag_warning.Count; i++)
            {
                line += dummy.Replace("{debug_compilerflag_warning}", main.debug_compilerflag_warning[i]) + "\n";
            }
        }
        else if (dummy.IndexOf("{release_compilerflag_warning}") > -1)
        {
            for (int i = 0; i < main.release_compilerflag_warning.Count; i++)
            {
                line += dummy.Replace("{release_compilerflag_warning}", main.release_compilerflag_warning[i]) + "\n";
            }
        }

        else if (dummy.IndexOf("{project_compilerflag_optimization}") > -1)
        {
            for (int i = 0; i < main.project_compilerflag_optimization.Count; i++)
            {
                line += dummy.Replace("{project_compilerflag_optimization}", main.project_compilerflag_optimization[i]) + "\n";
            }
        }
        else if (dummy.IndexOf("{debug_compilerflag_optimization}") > -1)
        {
            for (int i = 0; i < main.debug_compilerflag_optimization.Count; i++)
            {
                line += dummy.Replace("{debug_compilerflag_optimization}", main.debug_compilerflag_optimization[i]) + "\n";
            }
        }
        else if (dummy.IndexOf("{release_compilerflag_optimization}") > -1)
        {
            for (int i = 0; i < main.release_compilerflag_optimization.Count; i++)
            {
                line += dummy.Replace("{release_compilerflag_optimization}", main.release_compilerflag_optimization[i]) + "\n";
            }
        }

        else if (dummy.IndexOf("{project_compilerflag_debugging}") > -1)
        {
            for (int i = 0; i < main.project_compilerflag_debugging.Count; i++)
            {
                line += dummy.Replace("{project_compilerflag_debugging}", main.project_compilerflag_debugging[i]) + "\n";
            }
        }
        else if (dummy.IndexOf("{debug_compilerflag_debugging}") > -1)
        {
            for (int i = 0; i < main.debug_compilerflag_debugging.Count; i++)
            {
                line += dummy.Replace("{debug_compilerflag_debugging}", main.debug_compilerflag_debugging[i]) + "\n";
            }
        }
        else if (dummy.IndexOf("{release_compilerflag_debugging}") > -1)
        {
            for (int i = 0; i < main.release_compilerflag_debugging.Count; i++)
            {
                line += dummy.Replace("{release_compilerflag_debugging}", main.release_compilerflag_debugging[i]) + "\n";
            }
        }

        else if (dummy.IndexOf("{project_search_linker_directory}") > -1)
        {
            for (int i = 0; i < main.project_search_linker_directory.Count; i++)
            {
                line += dummy.Replace("{project_search_linker_directory}", main.project_search_linker_directory[i].Replace("\\", "/")) + "\n";
            }
        }
        else if (dummy.IndexOf("{debug_search_linker_directory}") > -1)
        {
            for (int i = 0; i < main.debug_search_linker_directory.Count; i++)
            {
                line += dummy.Replace("{debug_search_linker_directory}", main.debug_search_linker_directory[i].Replace("\\", "/")) + "\n";
            }
        }
        else if (dummy.IndexOf("{release_search_linker_directory}") > -1)
        {
            for (int i = 0; i < main.release_search_linker_directory.Count; i++)
            {
                line += dummy.Replace("{release_search_linker_directory}", main.release_search_linker_directory[i].Replace("\\", "/")) + "\n";
            }
        }

        else if (dummy.IndexOf("{project_link_options}") > -1)
        {
            for (int i = 0; i < main.project_link_options.Count; i++)
            {
                line += dummy.Replace("{project_link_options}", main.project_link_options[i]) + "\n";
            }
        }
        else if (dummy.IndexOf("{debug_link_options}") > -1)
        {
            for (int i = 0; i < main.debug_link_options.Count; i++)
            {
                line += dummy.Replace("{debug_link_options}", main.debug_link_options[i]) + "\n";
            }
        }
        else if (dummy.IndexOf("{release_link_options}") > -1)
        {
            for (int i = 0; i < main.release_link_options.Count; i++)
            {
                line += dummy.Replace("{release_link_options}", main.release_link_options[i]) + "\n";
            }
        }

        else if (dummy.IndexOf("{project_compilerflag_general}") > -1)
        {
            for (int i = 0; i < main.project_compilerflag_general.Count; i++)
            {
                line += dummy.Replace("{project_compilerflag_general}", main.project_compilerflag_general[i]) + "\n";
            }
        }
        else if (dummy.IndexOf("{debug_compilerflag_general}") > -1)
        {
            for (int i = 0; i < main.debug_compilerflag_general.Count; i++)
            {
                line += dummy.Replace("{debug_compilerflag_general}", main.debug_compilerflag_general[i]) + "\n";
            }
        }
        else if (dummy.IndexOf("{release_compilerflag_general}") > -1)
        {
            for (int i = 0; i < main.release_compilerflag_general.Count; i++)
            {
                line += dummy.Replace("{release_compilerflag_general}", main.release_compilerflag_general[i]) + "\n";
            }
        }

        else if (dummy.IndexOf("{project_link_libraries}") > -1)
        {
            for (int i = 0; i < main.project_link_libraries.Count; i++)
            {
                string dummy2 = main.project_link_libraries[i].Substring(3, main.project_link_libraries[i].Length - 3).Replace(".a", "");
                line += dummy.Replace("{project_link_libraries}", dummy2) + "\n";
            }
        }
        else if (dummy.IndexOf("{debug_link_libraries}") > -1)
        {
            for (int i = 0; i < main.debug_link_libraries.Count; i++)
            {
                string dummy2 = main.debug_link_libraries[i].Substring(3, main.debug_link_libraries[i].Length - 3).Replace(".a", "");
                line += dummy.Replace("{debug_link_libraries}", dummy2) + "\n";
            }
        }
        else if (dummy.IndexOf("{release_link_libraries}") > -1)
        {
            for (int i = 0; i < main.release_link_libraries.Count; i++)
            {
                string dummy2 = main.release_link_libraries[i].Substring(3, main.release_link_libraries[i].Length - 3).Replace(".a", "");
                line += dummy.Replace("{release_link_libraries}", dummy2) + "\n";
            }
        }

        else
        {
            line = dummy + "\n";
        }
        return line;
    }
}