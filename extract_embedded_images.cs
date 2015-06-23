//
// This code demonstrates how to extract embedded
// images from a PDF as the most appropriate file type
// based on stored image data.
//
// The code snippet is written in C#
//

string filename = "";

// Load your doc
int nd = DPL.LoadFromFile(@"images.pdf", "");

// Get page count from doc
int pC = DPL.PageCount();

// Iterate through each page
for (int i = 1; i <= pC; i++)
{
    // Select current page
    DPL.SelectPage(i);

    // Get list of images on the page
    int il = DPL.GetPageImageList(0);

    // Count number of images in the list
    int ic = DPL.GetImageListCount(il);
    for (int k = 1; k <= ic; k++)
    {
        // Iterate through each image and get the
        // image type and image ID
        int it = DPL.GetImageListItemIntProperty(il, k, 400);
        int gid = DPL.GetImageListItemIntProperty(il, k, 405);

        // Choose the approrpriate file extenion based on
        // the returned image type
        switch (it)
        {
		case 1:
			filename = "image-" + Convert.ToString(gid) + "-" + k + ".jpg";
			break;
		case 2:
			filename = "image-" + Convert.ToString(gid) + "-" + k + ".bmp";
			break;
		case 3:
			filename = "image-" + Convert.ToString(gid) + "-" + k + ".tif";
			break;
		case 4:
			filename = "image-" + Convert.ToString(gid) + "-" + k + ".png";
			break;
        }
        // Save the selected image to disk
        DPL.SaveImageListItemDataToFile(il, k, 0, filename);
    }
}
