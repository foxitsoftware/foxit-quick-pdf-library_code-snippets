// C# code snippet demonstrating which functions in 
// Debenu Quick PDF Library should be used to find and 
// replace links in PDF files.

// Load PDF to process
DPL.LoadFromFile(@"C:\Temp\debenu_quick_pdf_library_android\Debenu Cross Platform PDF Library 11.15 Reference Guide.pdf", "");
// Count pages in doc
int pCount = DPL.PageCount();

// Iterate through each page in the doc
for (int p = 1; p <= pCount; p++)
{
	// Select page to scan
	DPL.SelectPage(p);

	// Count annotations on the page
	int annotCount = DPL.AnnotationCount();

	// Loop through each annotation
	for (int a = 1; a <= annotCount; a++)
	{
		// Get annotation's ID
		int annotActionID = DPL.GetAnnotActionID(a);

		// Find out annotation's action type, we are looking for URI
		string actionType = DPL.GetActionType(annotActionID);

		// If action type is URI, we've found something to change
		if (actionType == "URI")
		{
			// Retrieve the string for the URI action type holding the URL
			string actionURL = DPL.GetActionURL(annotActionID);

			Console.WriteLine("Index: " + a + ", Annot ID: " + annotActionID + ", Action URL: " + actionURL);

			/* Option 1 */
			// Replace all URLs with a predefined new URL
			// First option is the simplest to demonstrate
			// the functions, just replace all
			// Action URL's with a new fixed URL.
			// Uncomment line below to use Option 1

			// DPL.SetActionURL(annotActionID, "http://www.example.com/");

			/* Option 2 */
			// Replace portion of URL if match found
			// The second option demonstrates how you
			// can replace one domain name with a new
			// domain name.

			string oldDomain = "www.debenu.com";
			string newDomain = "testing.debenu.com";

			if (actionURL.IndexOf(oldDomain) != -1)
			{
				// Create new StringBuilder from string.
				StringBuilder b = new StringBuilder(actionURL);

				// Replace the first word.
				// ... The result doesn't need assignment.
				b.Replace(oldDomain, newDomain);

				Console.WriteLine("Match found, replacing " + actionURL + " with " + b);
				Console.WriteLine(Environment.NewLine);

				DPL.SetActionURL(annotActionID, b.ToString());
			}
		}
	}
}
// Save the updated file to a new file
DPL.SaveToFile(@"C:\Temp\debenu_quick_pdf_library_android\Debenu Cross Platform PDF Library 11.15 Reference Guide3.pdf");
Console.Read();
