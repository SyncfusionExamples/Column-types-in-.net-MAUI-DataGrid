# Column-types-in-.net-MAUI-DataGrid
In this article, we will show you how to configure and switch between different column types in the .NET MAUI DataGrid (SfDataGrid). This sample uses a Picker to toggle between two source types (ObservableCollection and DataTable) and demonstrates defining explicit columns when the DataTable option is selected. For a complete list of available column types, please refer the documentation: [Column Types in .NET MAUI DataGrid](https://help.syncfusion.com/maui/datagrid/column-types) and the control overview: [.NET MAUI DataGrid (SfDataGrid) Overview](https://www.syncfusion.com/maui-controls/maui-datagrid).

## xaml
```
<ContentPage.BindingContext>
    <local:DealerInfoViewModel/>   
</ContentPage.BindingContext>


<ContentPage.Content>
    <StackLayout Orientation="Vertical">
        
        <ContentView>
            <Grid ColumnSpacing="10" Padding="20">

                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto" />
                </Grid.RowDefinitions>
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*"/>
                    <ColumnDefinition Width="*"/>
                </Grid.ColumnDefinitions>

                <Label 
            Grid.Row="0" Grid.Column="0"
            HorizontalOptions="Start"
            Text="Collection type"
            VerticalOptions="Center" FontSize="15">
                </Label>
                <Picker 
            Grid.Row="0" Grid.Column="1"
            x:Name="CollectionTypePicker"
            HorizontalOptions="StartAndExpand" SelectedIndexChanged="CollectionTypePicker_SelectedIndexChanged">

                    <Picker.Items>
                        <x:String>Observable collection</x:String>
                        <x:String>DataTable</x:String>
                    </Picker.Items>

                </Picker>
            </Grid>
        </ContentView>
        <syncfusion:SfDataGrid x:Name="dataGrid"
                        
                        ColumnWidthMode="FitByHeader"
                        GridLinesVisibility="Both"
                        HorizontalScrollBarVisibility="Default"
                        VerticalScrollBarVisibility="Default"
                        HeaderRowHeight="52"
                        RowHeight="48">
        </syncfusion:SfDataGrid>
    </StackLayout>
</ContentPage.Content>
```

## C#
The code-behind initializes a DataTable and assigns it to the grid. When the DataTable option is active, the grid’s Columns collection is populated with explicit column definitions. When you switch to an ObservableCollection, you can either auto-generate columns or define them explicitly for full control.
```
private void CollectionTypePicker_SelectedIndexChanged(object sender, EventArgs e)
{
    var picker = (Picker)sender;
    int selectedIndex = picker.SelectedIndex;
    this.dataGrid!.Columns.Clear();
    if (CollectionTypePicker.SelectedIndex == 0)

    {
        // this.dataGrid.ItemsSource = orderInfoViewModel!.OrdersInfo;
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
```

## Add more column types
Extend the sample by including other column types that match your data. These examples can be placed in XAML (when AutoGenerateColumnsMode is None) or created in code by instantiating the equivalent column classes.

- DataGridNumericColumn (numeric values and formatting)
```
<syncfusion:DataGridNumericColumn MappingName="Quantity"
                                  HeaderText="Qty"
                                  Format="N0" />
```

- DataGridDateColumn (date display and formatting)
```
<syncfusion:DataGridDateColumn MappingName="OrderDate"
                               HeaderText="Ordered"
                               Format="MM/dd/yyyy" />
```

- DataGridTemplateColumn (custom UI inside cells)
```
<syncfusion:DataGridTemplateColumn HeaderText="Actions">
    <syncfusion:DataGridTemplateColumn.CellTemplate>
        <DataTemplate>
            <HorizontalStackLayout Spacing="8">
                <Button Text="Edit"/>
                <Button Text="Delete"/>
            </HorizontalStackLayout>
        </DataTemplate>
    </syncfusion:DataGridTemplateColumn.CellTemplate>
</syncfusion:DataGridTemplateColumn>
```

Tips
- MappingName must match your data field or DataColumn name exactly.
- Set ColumnWidthMode to FitByCell or Auto to adapt widths to content.
- Clear Columns before redefining when switching sources to avoid duplicates.
- Set AutoGenerateColumnsMode="None" to take full control over visible columns and order.

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to use different column types in .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!
