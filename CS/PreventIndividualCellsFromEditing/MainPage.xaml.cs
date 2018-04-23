using System;
using System.Windows.Controls;

namespace PreventIndividualCellsFromEditing {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.DataSource = new ProductList();
        }

        private void TableView_ShowingEditor(object sender,
            DevExpress.Xpf.Grid.ShowingEditorEventArgs e) {
            if (e.Column.FieldName != "UnitPrice") return;
            e.Cancel = Convert.ToInt32(grid.GetCellValue(e.RowHandle, "Quantity")) == 0;
        }
    }
}
