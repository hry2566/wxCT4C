
namespace wxCT4C;

public partial class MainForm : Form
{
    internal string? project_directory;
    internal string? wxFormBuilder_project_file;
    internal string? MinGW_directory;
    internal string? wxWidgets_directory;
    internal List<string> project_compilerflag_general = new();
    internal List<string> project_compilerflag_debugging = new();
    internal List<string> project_compilerflag_profilling = new();
    internal List<string> project_compilerflag_warning = new();
    internal List<string> project_compilerflag_optimization = new();
    internal List<string> debug_compilerflag_general = new();
    internal List<string> debug_compilerflag_debugging = new();
    internal List<string> debug_compilerflag_profilling = new();
    internal List<string> debug_compilerflag_warning = new();
    internal List<string> debug_compilerflag_optimization = new();
    internal List<string> release_compilerflag_general = new();
    internal List<string> release_compilerflag_debugging = new();
    internal List<string> release_compilerflag_profilling = new();
    internal List<string> release_compilerflag_warning = new();
    internal List<string> release_compilerflag_optimization = new();
    internal List<string> project_other_compile_options = new();
    internal List<string> debug_other_compile_options = new();
    internal List<string> release_other_compile_options = new();
    internal List<string> project_other_resource_compile_options = new();
    internal List<string> debug_other_resource_compile_options = new();
    internal List<string> release_other_resource_compile_options = new();
    internal List<string> project_defines = new();
    internal List<string> debug_defines = new();
    internal List<string> release_defines = new();
    internal List<string> project_link_libraries = new();
    internal List<string> debug_link_libraries = new();
    internal List<string> release_link_libraries = new();
    internal List<string> project_link_options = new();
    internal List<string> debug_link_options = new();
    internal List<string> release_link_options = new();
    internal List<string> project_search_compiler_directory = new();
    internal List<string> debug_search_compiler_directory = new();
    internal List<string> release_search_compiler_directory = new();
    internal List<string> project_search_linker_directory = new();
    internal List<string> debug_search_linker_directory = new();
    internal List<string> release_search_linker_directory = new();
    internal List<string> project_search_resource_compiler_directory = new();
    internal List<string> debug_search_resource_compiler_directory = new();
    internal List<string> release_search_resource_compiler_directory = new();
    cls_Files files;
    public MainForm()
    {
        InitializeComponent();
        Compiler_Flags_Init();
        Build_Configure_Init();
        files = new cls_Files(this);
        files.Read_Init();
    }
    private void Compiler_Flags_Init()
    {
        string[] generalFlag = {
            "Position independent Code [-fPIC]",
            "Static libgcc [-static-libgcc]",
            "Static libstdc++ [-static-libstdc++]",
            "Static linking [-static]",
            "Target x86(32bit) [-m32]",
            "Target x86_64(64bit) [-m64]"
        };
        string[] debugging ={
            "Optimize debugging executable(compile speed, execution speed and better debugging) [-Og]",
            "Produce debugging symbols [-g]"
        };
        string[] profilling ={
            "Profile code when executed [-pg]"
        };
        string[] warnings ={
            "Enable all common computer warnings(overrides many other settings [-Wall]",
            "Enable Effective-C++ warnings [-Weffc++] ",
            "Enable extra compiler warnings [-Wextra]",
            "Enable warnings demanded by strict ISO C and ISO C++ [-pedantic]",
            "Inhibit all warning messages [-w]",
            "Stop compiling after first error [-Wfatal-errors]",
            "Treat as error the warnings demanded by static ISP C and ISO C++ [-pedantic-errors]",
            "Warn about unitialized variables which are initialized with themselves [-Winit-self]",
            "Warn if '0' is used as a null pointer contant [-Wzero-as-null-pointer-constant]",
            "Warn if class virtual functions but no virtual destructor [-Wnon-virtual-dtor]",
            "Warn if a function can not be inlined and it was declared as inline [-Winline]",
            "Warn if a global function is defined without a previous declaration [-Wmissing-declarations]",
            "Warn if a user supplied include directory does not exist [-Wmissing—include—dirs]",
            "Warn if an undefined identifier is evaluated in an '#if' directive [-Wundef]",
            "Warn if anything is declared more than once in the same scope [-Wredundant—decls]",
            "Warn if floating point values are used in equality comparisons [-Wfloat-equal]",
            "Warn if main() is not conformant [-Wmain]",
            "Warn if the compiler detects that code will never be executed [-Wunreachable-code]",
            "Warn whenever a local variable shadows another local variable, parameter or global variable or whenever a built—in funcion is shadowes [-Wshadow]",
            "Warn whenever a pointer is cast such that the required alignment of the target is increased [-Wcast-align]",
            "Warn whenever a switch statement does not have a default case [-Wswitch—default]",
            "Warn whenever a switch statement has an index of enumerated type and lacks a case for one or more of the named codes of that enumeration [-Wswitch-enum]"
        };
        string[] optimization ={
            // " [-O1]",
            // " [-O2]",
            // " [-O3]",
            "Don't keep the frame pointer in a register for functions that don't need one [-fomit—frame-pointer]",
            "Expensive optimizations [-fexpensive-optimizations]",
            "Link—Time—Optimization [-flto]",
            "Optimize even more (for speed) [-O2]",
            "Optimize fully (for speed) [-O3]",
            "Optimize generated code (for size) [-Os]",
            "Optimize generated code (for speed) [-O]",
            "Optimize more (for speed) [-O1]",
            "Strip all symbols from binary (minimizes size) [-s]"
        };

        for (int i = 0; i < generalFlag.Length; i++)
        {
            CheckedListBox0.Items.Add(generalFlag[i]);
        }
        for (int i = 0; i < debugging.Length; i++)
        {
            CheckedListBox1.Items.Add(debugging[i]);
        }
        for (int i = 0; i < profilling.Length; i++)
        {
            CheckedListBox2.Items.Add(profilling[i]);
        }
        for (int i = 0; i < warnings.Length; i++)
        {
            CheckedListBox3.Items.Add(warnings[i]);
        }
        for (int i = 0; i < optimization.Length; i++)
        {
            CheckedListBox4.Items.Add(optimization[i]);
        }
    }
    private void Build_Configure_Init()
    {
        TreeNode rootNode = new TreeNode();
        TreeNode childNode1 = new TreeNode();
        TreeNode childNode2 = new TreeNode();

        rootNode.Text = "Project";
        childNode1.Text = "Debug";
        childNode2.Text = "Release";
        rootNode.Nodes.Add(childNode1);
        rootNode.Nodes.Add(childNode2);
        TreeView0.Nodes.Add(rootNode);
        TreeView0.ExpandAll();
        TreeView0.SelectedNode = TreeView0.Nodes[0];
    }
    private void TreeView0_AfterSelect(System.Object? sender, System.Windows.Forms.TreeViewEventArgs e)
    {
        TreeNode SelectedNode = new TreeNode();
        SelectedNode = TreeView0.SelectedNode;

        cls_Draw Draw = new cls_Draw(this);
        List<CheckedListBox> lst_CheckedListBox = new() { CheckedListBox0, CheckedListBox1, CheckedListBox2, CheckedListBox3, CheckedListBox4 };
        List<TextBox> lst_TextBox = new() { TextBox4, TextBox5, TextBox6, TextBox7 };
        List<ListBox> lst_ListBox = new() { ListBox0, ListBox1, ListBox2, ListBox3 };
        Draw.Draw_Other_Items(SelectedNode.Text, lst_CheckedListBox, lst_TextBox, lst_ListBox);
    }
    private void Button12_Click(System.Object? sender, System.EventArgs e)
    {
        files.Save();
    }
    internal void Draw_Main_Items()
    {
        TextBox0.Text = project_directory;
        TextBox1.Text = wxFormBuilder_project_file;
        TextBox2.Text = MinGW_directory;
        TextBox3.Text = wxWidgets_directory;
    }
    private void Button0_Click(System.Object? sender, System.EventArgs e)
    {
        project_directory = files.Select_Dlg("directory", project_directory);
        Draw_Main_Items();
    }

    private void Button1_Click(System.Object? sender, System.EventArgs e)
    {
        wxFormBuilder_project_file = files.Select_Dlg("file", wxFormBuilder_project_file);
        Draw_Main_Items();
    }

    private void Button2_Click(System.Object? sender, System.EventArgs e)
    {
        MinGW_directory = files.Select_Dlg("directory", MinGW_directory);
        Draw_Main_Items();
    }

    private void Button3_Click(System.Object? sender, System.EventArgs e)
    {
        wxWidgets_directory = files.Select_Dlg("directory", wxWidgets_directory);
        Draw_Main_Items();
    }
    private void CheckedListBox0_ItemCheck(System.Object? sender, System.Windows.Forms.ItemCheckEventArgs e)
    {
        if (e.Index == 4 && e.NewValue == CheckState.Checked)
        {
            CheckedListBox0.SetItemChecked(5, false);
        }
        else if (e.Index == 5 && e.NewValue == CheckState.Checked)
        {
            CheckedListBox0.SetItemChecked(4, false);
        }
    }
    private void CheckedListBox1_ItemCheck(System.Object? sender, System.Windows.Forms.ItemCheckEventArgs e)
    {

    }

    private void CheckedListBox2_ItemCheck(System.Object? sender, System.Windows.Forms.ItemCheckEventArgs e)
    {

    }

    private void CheckedListBox3_ItemCheck(System.Object? sender, System.Windows.Forms.ItemCheckEventArgs e)
    {
        if (e.Index == 0)
        {
            CheckedListBox3.SetItemChecked(4, false);
        }
        else if (e.Index == 4)
        {
            CheckedListBox3.SetItemChecked(0, false);
        }
    }

    private void CheckedListBox4_ItemCheck(System.Object? sender, System.Windows.Forms.ItemCheckEventArgs e)
    {
        if (e.Index == 3)
        {
            CheckedListBox4.SetItemChecked(4, false);
            CheckedListBox4.SetItemChecked(5, false);
            CheckedListBox4.SetItemChecked(6, false);
            CheckedListBox4.SetItemChecked(7, false);
        }
        else if (e.Index == 4)
        {
            CheckedListBox4.SetItemChecked(3, false);
            CheckedListBox4.SetItemChecked(5, false);
            CheckedListBox4.SetItemChecked(6, false);
            CheckedListBox4.SetItemChecked(7, false);
        }
        else if (e.Index == 5)
        {
            CheckedListBox4.SetItemChecked(3, false);
            CheckedListBox4.SetItemChecked(4, false);
            CheckedListBox4.SetItemChecked(6, false);
            CheckedListBox4.SetItemChecked(7, false);
        }
        else if (e.Index == 6)
        {
            CheckedListBox4.SetItemChecked(3, false);
            CheckedListBox4.SetItemChecked(4, false);
            CheckedListBox4.SetItemChecked(5, false);
            CheckedListBox4.SetItemChecked(7, false);
        }
        else if (e.Index == 7)
        {
            CheckedListBox4.SetItemChecked(3, false);
            CheckedListBox4.SetItemChecked(4, false);
            CheckedListBox4.SetItemChecked(5, false);
            CheckedListBox4.SetItemChecked(6, false);
        }
    }
    private void TreeView0_BeforeSelect(System.Object? sender, System.Windows.Forms.TreeViewCancelEventArgs e)
    {

    }
    private void Update_Compilerflag_General()
    {
        project_compilerflag_general.Clear();
        for (int i = 0; i < CheckedListBox0.Items.Count; i++)
        {
            if (CheckedListBox0.GetItemChecked(i))
            {
                string[] split = CheckedListBox0.Items[i].ToString()!.Split("[");
                string? value = split[1].Replace("]", "");
                project_compilerflag_general.Add(value);
            }
        }
    }

}
