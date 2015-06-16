// C# sample code, this does not demonstrate the initialization and unlocking of Debenu Quick PDF Library

int r1 = DPL.DAOpenFile(@"dev_guide.pdf", ""); // Load sample file
int r2 = DPL.DAFindPage(r1, 2); // Second parameter is page to use for text extraction
double ph = DPL.DAGetPageHeight(r1, r2); // Get page height
double pw = DPL.DAGetPageWidth(r1, r2); // Get get width
DPL.DASetTextExtractionArea(0, ph, pw, ph); // Adjust text extraction area here, currently set to full page
string r3 = DPL.DAExtractPageText(r1, r2, 3); // Extract the text
System.IO.File.WriteAllText(@"extracted_text.txt", r3); // Save text file with output
