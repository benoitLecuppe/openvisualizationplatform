// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace OpenVP.GtkGui {
    
    
    public partial class LinearPresetEditor {
        
        private Gtk.Notebook notebook1;
        
        private Gtk.HPaned hpaned1;
        
        private Gtk.VBox vbox1;
        
        private Gtk.HButtonBox hbuttonbox1;
        
        private Gtk.Button AddEffect;
        
        private Gtk.Button RemoveEffect;
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private Gtk.TreeView treeview1;
        
        private Gtk.Alignment EffectPane;
        
        private Gtk.Label label1;
        
        private Gtk.Label label2;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget OpenVP.GtkGui.LinearPresetEditor
            Stetic.BinContainer.Attach(this);
            this.Name = "OpenVP.GtkGui.LinearPresetEditor";
            // Container child OpenVP.GtkGui.LinearPresetEditor.Gtk.Container+ContainerChild
            this.notebook1 = new Gtk.Notebook();
            this.notebook1.CanFocus = true;
            this.notebook1.Name = "notebook1";
            this.notebook1.CurrentPage = 0;
            // Container child notebook1.Gtk.Notebook+NotebookChild
            this.hpaned1 = new Gtk.HPaned();
            this.hpaned1.CanFocus = true;
            this.hpaned1.Name = "hpaned1";
            this.hpaned1.Position = 211;
            // Container child hpaned1.Gtk.Paned+PanedChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hbuttonbox1 = new Gtk.HButtonBox();
            this.hbuttonbox1.Name = "hbuttonbox1";
            this.hbuttonbox1.Homogeneous = true;
            this.hbuttonbox1.Spacing = 6;
            // Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
            this.AddEffect = new Gtk.Button();
            this.AddEffect.CanFocus = true;
            this.AddEffect.Name = "AddEffect";
            this.AddEffect.UseStock = true;
            this.AddEffect.UseUnderline = true;
            this.AddEffect.Label = "gtk-add";
            this.hbuttonbox1.Add(this.AddEffect);
            Gtk.ButtonBox.ButtonBoxChild w1 = ((Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1[this.AddEffect]));
            w1.Expand = false;
            w1.Fill = false;
            // Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
            this.RemoveEffect = new Gtk.Button();
            this.RemoveEffect.CanFocus = true;
            this.RemoveEffect.Name = "RemoveEffect";
            this.RemoveEffect.UseStock = true;
            this.RemoveEffect.UseUnderline = true;
            this.RemoveEffect.Label = "gtk-remove";
            this.hbuttonbox1.Add(this.RemoveEffect);
            Gtk.ButtonBox.ButtonBoxChild w2 = ((Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1[this.RemoveEffect]));
            w2.Position = 1;
            w2.Expand = false;
            w2.Fill = false;
            this.vbox1.Add(this.hbuttonbox1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbuttonbox1]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.treeview1 = new Gtk.TreeView();
            this.treeview1.CanFocus = true;
            this.treeview1.Name = "treeview1";
            this.treeview1.HeadersClickable = true;
            this.GtkScrolledWindow.Add(this.treeview1);
            this.vbox1.Add(this.GtkScrolledWindow);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
            w5.Position = 1;
            this.hpaned1.Add(this.vbox1);
            Gtk.Paned.PanedChild w6 = ((Gtk.Paned.PanedChild)(this.hpaned1[this.vbox1]));
            w6.Resize = false;
            // Container child hpaned1.Gtk.Paned+PanedChild
            this.EffectPane = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            this.EffectPane.Name = "EffectPane";
            this.hpaned1.Add(this.EffectPane);
            this.notebook1.Add(this.hpaned1);
            // Notebook tab
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Effects");
            this.notebook1.SetTabLabel(this.hpaned1, this.label1);
            this.label1.ShowAll();
            // Notebook tab
            Gtk.Label w9 = new Gtk.Label();
            w9.Visible = true;
            this.notebook1.Add(w9);
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Keybindings");
            this.notebook1.SetTabLabel(w9, this.label2);
            this.label2.ShowAll();
            this.Add(this.notebook1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
            this.AddEffect.Clicked += new System.EventHandler(this.OnAddEffectClicked);
        }
    }
}
