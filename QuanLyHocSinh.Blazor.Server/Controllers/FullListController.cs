
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Blazor.Editors;


namespace QuanLyHocSinh.Blazor.Server.Controllers
{
   
    public partial class FullListController : ViewController<ListView>
    {
       
        public FullListController()
        {
            InitializeComponent();
            
        }
        
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();

            if (View.Editor is DxGridListEditor gridListEditor)
            {
                IDxGridAdapter dataGridAdapter = gridListEditor.GetGridAdapter();
                //dataGridAdapter.GridModel.ColumnResizeMode = DevExpress.Blazor.GridColumnResizeMode.Disabled;
                dataGridAdapter.GridModel.ShowGroupPanel = true;
                dataGridAdapter.GridModel.FooterDisplayMode = DevExpress.Blazor.GridFooterDisplayMode.Auto;
                dataGridAdapter.GridModel.AutoExpandAllGroupRows = true;
                dataGridAdapter.GridModel.ShowFilterRow = true;
            }
        }
       
    }
}
