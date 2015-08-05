// C# sample code, this does not demonstrate the initialization and unlocking of Debenu Quick PDF Library

// SetTextExtractionArea with GetPageText

DPL.LoadFromFile(@"Sample.pdf", "");
DPL.SetOrigin(1); // Sets 0,0 coordinate position to top left of page, default is bottom left
DPL.SetTextExtractionArea(35, 35, 229, 30); // Left, Top, Width, Height
string ExtractedContent = DPL.GetPageText(8);
Console.WriteLine(ExtractedContent);

// DASetTextExtractionArea with ExtractFilePageText

DPL.DASetTextExtractionArea(35, 757, 229, 30); // Left, Top, Width, Height
ExtractedContent = DPL.ExtractFilePageText(@"Sample.pdf", "", 1, 8);
Console.WriteLine(ExtractedContent);

// DASetTextExtractionArea with DAExtractPageText

int fileHandle = DPL.DAOpenFile(@"Sample.pdf", "");
int pageRef = DPL.DAFindPage(fileHandle, 1);
DPL.DASetTextExtractionArea(35, 757, 229, 30); // Left, Top, Width, Height
ExtractedContent = DPL.DAExtractPageText(fileHandle, pageRef, 8);
Console.WriteLine(ExtractedContent);
