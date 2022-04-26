namespace wxCT4C;

public partial class cls_Draw
{
    MainForm main;
    public cls_Draw(MainForm main)
    {
        this.main = main;
    }
    internal void Draw_Other_Items(string mode, List<CheckedListBox> lst_CheckedListBox, List<TextBox> lst_TextBox, List<ListBox> lst_ListBox)
    {
        Draw_Compilerflag_General(mode, lst_CheckedListBox[0]);
        Draw_Compilerflag_Debugging(mode, lst_CheckedListBox[1]);
        Draw_Compilerflag_Profilling(mode, lst_CheckedListBox[2]);
        Draw_Compilerflag_Warning(mode, lst_CheckedListBox[3]);
        Draw_Compilerflag_Optimization(mode, lst_CheckedListBox[4]);
        Draw_Other_Compiler_Options(mode, lst_TextBox[0]);
        Draw_Other_Resource_Compiler_Options(mode, lst_TextBox[1]);
        Draw_Defines(mode, lst_TextBox[2]);
        Draw_Linker_Settings(mode, lst_ListBox[0], lst_TextBox[3]);
        Draw_Search_Directories(mode, lst_ListBox[1], lst_ListBox[2], lst_ListBox[3]);
    }
    private void Draw_Compilerflag_General(string mode, CheckedListBox CheckedListBox0)
    {
        string? lstBox;
        string? flag;
        List<string> arrayList = new();

        switch (mode)
        {
            case "Project":
                arrayList = main.project_compilerflag_general;
                break;
            case "Debug":
                arrayList = main.debug_compilerflag_general;
                break;
            case "Release":
                arrayList = main.release_compilerflag_general;
                break;
        }

        for (int i = 0; i < CheckedListBox0.Items.Count; i++)
        {
            lstBox = CheckedListBox0.Items[i].ToString();
            CheckedListBox0.SetItemChecked(i, false);

            for (int j = 0; j < arrayList.Count; j++)
            {
                flag = "[" + arrayList[j] + "]";
                if (lstBox!.IndexOf(flag) > -1)
                {
                    CheckedListBox0.SetItemChecked(i, true);
                    break;
                }
            }
        }
    }
    private void Draw_Compilerflag_Debugging(string mode, CheckedListBox CheckedListBox1)
    {
        string? lstBox;
        string? flag;
        List<string> arrayList = new();

        switch (mode)
        {
            case "Project":
                arrayList = main.project_compilerflag_debugging;
                break;
            case "Debug":
                arrayList = main.debug_compilerflag_debugging;
                break;
            case "Release":
                arrayList = main.release_compilerflag_debugging;
                break;
        }

        for (int i = 0; i < CheckedListBox1.Items.Count; i++)
        {
            lstBox = CheckedListBox1.Items[i].ToString();
            CheckedListBox1.SetItemChecked(i, false);

            for (int j = 0; j < arrayList.Count; j++)
            {
                flag = "[" + arrayList[j] + "]";
                if (lstBox!.IndexOf(flag) > -1)
                {
                    CheckedListBox1.SetItemChecked(i, true);
                    break;
                }
            }
        }
    }
    private void Draw_Compilerflag_Profilling(string mode, CheckedListBox CheckedListBox2)
    {
        string? lstBox;
        string? flag;
        List<string> arrayList = new();

        switch (mode)
        {
            case "Project":
                arrayList = main.project_compilerflag_profilling;
                break;
            case "Debug":
                arrayList = main.debug_compilerflag_profilling;
                break;
            case "Release":
                arrayList = main.release_compilerflag_profilling;
                break;
        }

        for (int i = 0; i < CheckedListBox2.Items.Count; i++)
        {
            lstBox = CheckedListBox2.Items[i].ToString();
            CheckedListBox2.SetItemChecked(i, false);

            for (int j = 0; j < arrayList.Count; j++)
            {
                flag = "[" + arrayList[j] + "]";
                if (lstBox!.IndexOf(flag) > -1)
                {
                    CheckedListBox2.SetItemChecked(i, true);
                    break;
                }
            }
        }
    }
    private void Draw_Compilerflag_Warning(string mode, CheckedListBox CheckedListBox3)
    {
        string? lstBox;
        string? flag;
        List<string> arrayList = new();

        switch (mode)
        {
            case "Project":
                arrayList = main.project_compilerflag_warning;
                break;
            case "Debug":
                arrayList = main.debug_compilerflag_warning;
                break;
            case "Release":
                arrayList = main.release_compilerflag_warning;
                break;
        }

        for (int i = 0; i < CheckedListBox3.Items.Count; i++)
        {
            lstBox = CheckedListBox3.Items[i].ToString();
            CheckedListBox3.SetItemChecked(i, false);

            for (int j = 0; j < arrayList.Count; j++)
            {
                flag = "[" + arrayList[j] + "]";
                if (lstBox!.IndexOf(flag) > -1)
                {
                    CheckedListBox3.SetItemChecked(i, true);
                    break;
                }
            }
        }
    }
    private void Draw_Compilerflag_Optimization(string mode, CheckedListBox CheckedListBox4)
    {
        string? lstBox;
        string? flag;
        List<string> arrayList = new();

        switch (mode)
        {
            case "Project":
                arrayList = main.project_compilerflag_optimization;
                break;
            case "Debug":
                arrayList = main.debug_compilerflag_optimization;
                break;
            case "Release":
                arrayList = main.release_compilerflag_optimization;
                break;
        }

        for (int i = 0; i < CheckedListBox4.Items.Count; i++)
        {
            lstBox = CheckedListBox4.Items[i].ToString();
            CheckedListBox4.SetItemChecked(i, false);

            for (int j = 0; j < arrayList.Count; j++)
            {
                flag = "[" + arrayList[j] + "]";
                if (lstBox!.IndexOf(flag) > -1)
                {
                    CheckedListBox4.SetItemChecked(i, true);
                    break;
                }
            }
        }
    }
    private void Draw_Other_Compiler_Options(string mode, TextBox TextBox4)
    {
        TextBox4.Text = "";
        List<string> arrayList1 = new();

        switch (mode)
        {
            case "Project":
                arrayList1 = main.project_other_compile_options;
                break;
            case "Debug":
                arrayList1 = main.debug_other_compile_options;
                break;
            case "Release":
                arrayList1 = main.release_other_compile_options;
                break;
        }

        for (int i = 0; i < arrayList1.Count; i++)
        {
            TextBox4.Text += arrayList1[i] + Environment.NewLine;
        }
    }
    private void Draw_Other_Resource_Compiler_Options(string mode, TextBox TextBox5)
    {
        TextBox5.Text = "";
        List<string> arrayList1 = new();

        switch (mode)
        {
            case "Project":
                arrayList1 = main.project_other_resource_compile_options;
                break;
            case "Debug":
                arrayList1 = main.debug_other_resource_compile_options;
                break;
            case "Release":
                arrayList1 = main.release_other_resource_compile_options;
                break;
        }

        for (int i = 0; i < arrayList1.Count; i++)
        {
            TextBox5.Text += arrayList1[i] + Environment.NewLine;
        }
    }
    private void Draw_Defines(string mode, TextBox TextBox6)
    {
        TextBox6.Text = "";
        List<string> arrayList1 = new();

        switch (mode)
        {
            case "Project":
                arrayList1 = main.project_defines;
                break;
            case "Debug":
                arrayList1 = main.debug_defines;
                break;
            case "Release":
                arrayList1 = main.release_defines;
                break;
        }

        for (int i = 0; i < arrayList1.Count; i++)
        {
            TextBox6.Text += arrayList1[i] + Environment.NewLine;
        }
    }
    private void Draw_Linker_Settings(string mode, ListBox ListBox0, TextBox TextBox7)
    {
        ListBox0.Items.Clear();
        TextBox7.Text = "";

        List<string> arrayList = new();
        List<string> arrayList2 = new();

        switch (mode)
        {
            case "Project":
                arrayList = main.project_link_libraries;
                arrayList2 = main.project_link_options;
                break;
            case "Debug":
                arrayList = main.debug_link_libraries;
                arrayList2 = main.debug_link_options;
                break;
            case "Release":
                arrayList = main.release_link_libraries;
                arrayList2 = main.release_link_options;
                break;
        }

        for (int i = 0; i < arrayList.Count; i++)
        {
            ListBox0.Items.Add(arrayList[i]);
        }

        for (int i = 0; i < arrayList2.Count; i++)
        {
            TextBox7.Text += arrayList2[i] + Environment.NewLine;
        }
    }
    private void Draw_Search_Directories(string mode, ListBox ListBox1, ListBox ListBox2, ListBox ListBox3)
    {
        ListBox1.Items.Clear();
        ListBox2.Items.Clear();
        ListBox3.Items.Clear();

        List<string> arrayList1 = new();
        List<string> arrayList2 = new();
        List<string> arrayList3 = new();

        switch (mode)
        {
            case "Project":
                arrayList1 = main.project_search_compiler_directory;
                arrayList2 = main.project_search_linker_directory;
                arrayList3 = main.project_search_resource_compiler_directory;
                break;
            case "Debug":
                arrayList1 = main.debug_search_compiler_directory;
                arrayList2 = main.debug_search_linker_directory;
                arrayList3 = main.debug_search_resource_compiler_directory;
                break;
            case "Release":
                arrayList1 = main.release_search_compiler_directory;
                arrayList2 = main.release_search_linker_directory;
                arrayList3 = main.release_search_resource_compiler_directory;
                break;
        }

        for (int i = 0; i < arrayList1.Count; i++)
        {
            ListBox1.Items.Add(arrayList1[i]);
        }

        for (int i = 0; i < arrayList2.Count; i++)
        {
            ListBox2.Items.Add(arrayList2[i]);
        }

        for (int i = 0; i < arrayList3.Count; i++)
        {
            ListBox3.Items.Add(arrayList3[i]);
        }
    }
}