// --------------------------------------------------
// Code Snippet: Create Simple Table Layout
//
// This code snippet shows you how to use the
// table functions in Debenu Quick PDF Library
// to more easily control the layout and placement
// of content in your PDF
//
// The code snippet is written in C#
// --------------------------------------------------

// Set the page size of the new document

DPL.SetPageSize("Letter");

// Create the table and specify the number of rows and columns

int tableID = DPL.CreateTable(5, 5);

// Specify color and width of borders   

DPL.SetTableBorderColor(tableID, 0, 0.3, 0.204, 0);
DPL.SetTableBorderWidth(tableID, 0, 0.2);

// Specify table row height and table column width

DPL.SetTableRowHeight(tableID, 1, 5, 0);
DPL.SetTableColumnWidth(tableID, 1, 5, 100);

// Specify a background color for the column headers

DPL.SetTableCellBackgroundColor(tableID, 1, 1, 1, 5, 0.3, 0.7, 1.0);
DPL.SetTableCellAlignment(tableID, 1, 1, 1, 5, 4);

// Setup the column headers and content for the first row

DPL.SetTableCellContent(tableID, 1, 1, "<b>This Week</b>");
DPL.SetTableCellContent(tableID, 1, 2, "<b>Last Week</b>");
DPL.SetTableCellContent(tableID, 1, 3, "<b>Artist Name</b>");
DPL.SetTableCellContent(tableID, 1, 4, "<b>Peak</b>");
DPL.SetTableCellContent(tableID, 1, 5, "<b>Weeks On</b>");

// Insert the content for the second row

DPL.SetTableCellContent(tableID, 2, 1, "1");
DPL.SetTableCellContent(tableID, 2, 2, "1");
DPL.SetTableCellContent(tableID, 2, 3, "<b>The Black Eyed Peas</b><br>Boom Boom Pow");
DPL.SetTableCellContent(tableID, 2, 4, "<b>1</b>");
DPL.SetTableCellContent(tableID, 2, 5, "<b>11</b>");

// Insert the content for the third row

DPL.SetTableCellContent(tableID, 3, 1, "2");
DPL.SetTableCellContent(tableID, 3, 2, "3");
DPL.SetTableCellContent(tableID, 3, 3, "<b>Missy Higgins</b><br>Life is a rainbow");
DPL.SetTableCellContent(tableID, 3, 4, "<b>2</b>");
DPL.SetTableCellContent(tableID, 3, 5, "<b>8</b>");

// Insert the content for the fourth row

DPL.SetTableCellContent(tableID, 4, 1, "3");
DPL.SetTableCellContent(tableID, 4, 2, "2");
DPL.SetTableCellContent(tableID, 4, 3, "<b>Silverchair</b><br>The Door");
DPL.SetTableCellContent(tableID, 4, 4, "<b>3</b>");
DPL.SetTableCellContent(tableID, 4, 5, "<b>7</b>");

// Insert the content for the fourth row

DPL.SetTableCellContent(tableID, 5, 1, "4");
DPL.SetTableCellContent(tableID, 5, 2, "4");
DPL.SetTableCellContent(tableID, 5, 3, "<b>Rolling Stones</b><br>Sweet Virginia");
DPL.SetTableCellContent(tableID, 5, 4, "<b>4</b>");
DPL.SetTableCellContent(tableID, 5, 5, "<b>19</b>");

// Draw the table onto the document

DPL.SetOrigin(1);
DPL.DrawTableRows(tableID, 50, 50, 400, 1, 0);

// Save the document to disk
DPL.SaveToFile("table.pdf");
