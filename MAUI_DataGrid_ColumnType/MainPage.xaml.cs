using Syncfusion.Maui.Data;
using Syncfusion.Maui.DataGrid;
using System.Data;

namespace MAUI_DataGrid_ColumnType;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        DataTable table = this.GetDataTable();
        this.dataGrid.ItemsSource = table;


    }

    private DataTable GetDataTable()
    {
        DataTable employeeCollection = new DataTable();
        employeeCollection.Columns.Add("CustomerID", typeof(string));
        employeeCollection.Columns.Add("Company", typeof(string));
        employeeCollection.Columns.Add("ContactName", typeof(string));
        employeeCollection.Columns.Add("City", typeof(string));
        employeeCollection.Rows.Add("ALFKI", "Alferds Futterkiste", "Maria Anders", "Berlin");
        employeeCollection.Rows.Add("ANATR", "Ana Trujilo Emparedados y Hela", "Ana Trujilo", "Mexico D.F.");
        employeeCollection.Rows.Add("ANTON", "Antonio Moreno Taqueria", "Antonio Moreno", "Mexico D.F.");
        employeeCollection.Rows.Add("AROUT", "Around the Horn", "Thomas Hardy", "London");
        employeeCollection.Rows.Add("BERGS", "Berglunds Snabbkop", "Christina Berglund", "Lulea");
        employeeCollection.Rows.Add("BLAUS", "Blauer see Delikatessen", "Hanna Moss", "Mannheim");
        employeeCollection.Rows.Add("BLONP", "Blondel Pere et Fils", "Erederique Citeaux", "Strasbourg");
        employeeCollection.Rows.Add("BOLID", "Bolids Comidas Preparadas", "Martin Sommer", "Madrid");
        employeeCollection.Rows.Add("BONP", "Bon App", "Laurence Lebihan", "Marseille");
        employeeCollection.Rows.Add("BOTTM", "Bottom-Dollar Markets", "Elizabeth Lincoln", "Tsawassen");
        employeeCollection.Rows.Add("BSBEV", "B's Beverages", "Victoria Ashworth", "London");
        employeeCollection.Rows.Add("CACTU", "Cactus Comidas para llevar", "Patricio Simpson", "Bueno Aires");
        employeeCollection.Rows.Add("CENTC", "Centro Comercial Moctezuma", "Francisco Chang", "Mexico D.F.");
        employeeCollection.Rows.Add("CHOPS", "Chop-Suey Chinese", "Yang Wang", "Bern");
        employeeCollection.Rows.Add("COMMI", "Comercio Minerio", "Pedro Afonso", "Sao Paulo");
        employeeCollection.Rows.Add("CONSH", "Consolidated Holdings", "Elizabeth Brown", "London");
        employeeCollection.Rows.Add("DRACD", "Drachenblut Entier", "Sven Ottlieb", "Aachen");
        employeeCollection.Rows.Add("DUMON", "Dumonde Entier", "Janine Labrune", "Nantes");
        employeeCollection.Rows.Add("EASTC", "Eastern Connection", "Ann Devon", "London");
        employeeCollection.Rows.Add("ERNSH", "Ernst Handel", "Roland Mendel", "Graz");
        return employeeCollection;
    }

    private void CollectionTypePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;
        this.dataGrid!.Columns.Clear();
        if (CollectionTypePicker.SelectedIndex == 0)

        {
            //this.dataGrid.ItemsSource = orderInfoViewModel!.OrdersInfo;
        }
        else
        {
            this.dataGrid!.Columns.Clear();
            DataTable table = this.GetDataTable();
            this.dataGrid.ItemsSource = table;
            DataGridTextColumn customerId = new DataGridTextColumn();
            customerId.MappingName = "CustomerID";
            customerId.HeaderText = "ID";

            DataGridTextColumn companyName = new DataGridTextColumn();
            companyName.MappingName = "Company";
            companyName.HeaderText = "Company";

            DataGridTextColumn contactName = new DataGridTextColumn();
            contactName.MappingName = "ContactName";
            contactName.HeaderText = "Contact Name";

            DataGridTextColumn city = new DataGridTextColumn();
            city.MappingName = "City";
            city.HeaderText = "City";

            this.dataGrid.Columns.Add(customerId);
            this.dataGrid.Columns.Add(companyName);
            this.dataGrid.Columns.Add(contactName);
            this.dataGrid.Columns.Add(city);
        }
    }
}

