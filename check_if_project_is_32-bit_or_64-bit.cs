// This C# code will tell you if your project is
// executing using 32-bit or 64-bit architecture.

if(IntPtr.Size == 8) 
{
// 64 bit machine
} 
else if(IntPtr.Size == 4) 
{
// 32 bit machine
}

// Usage example in initializing DLL edition
// of Debenu Quick PDF Library in C# project.

// Remember to add "using DebenuPDFLibraryDLL1115;"
// to the top of your file.

// DLL Edition setup
PDFLibrary DPL;
//Library Version setup
int DPLVer = 1115;

// Different filename for 32-bit and 64-bit DLL
string DLLprefix = "DebenuPDFLibraryDLL";
string DLL64prefix = "DebenuPDFLibrary64DLL";
 
string dllName;
 
// Debenu Quick PDF Library is provided in 32-bit and 64-bit verisons. We can
// automatically check which should be used based on what arcitecture the website
// project is targeting.
 
// Check to see if IntPtr size is 4. If 4 then it's 32-bit, if 8 then it is 64-bit.
if (IntPtr.Size == 4)
{
    dllName = DLLprefix + DPLVer.ToString("D4") + ".DLL"; // 32 bits 
}
else
{
    dllName = DLL64prefix + DPLVer.ToString("D4") + ".DLL"; // 64 bits 
}
 
// Load the library from the Lib folder
// Update the
DPL = new PDFLibrary("path_to_folder_with_dlls" + dllName));
// Check to see if library loaded successfully, LibraryVersion 
// can be called before UnlockKey function is used
 
if (DPL.LibraryVersion() != "")
{
    // LibraryVersion has returned a result so we're up and running
    string LibVer = DPL.LibraryVersion();
    MessageBox.Show(LibVer);
}
else
{
    // If this is returned then the library was not successfully initialized.
    MessageBox.Show("Debenu Quick PDF Library version not found. Library not initialized successfully.");
}
 
// Now we can unlock the library using our
// license key to get the library fully working
if (DPL.UnlockKey("...insert_license_key_here...") != 0)
{
    MessageBox.Show("Debenu Quick PDF Library was unlocked successfully.");
 
    // Now lets create a PDF!
 
    DPL.DrawText(100, 100, "Hello world");
    DPL.SaveToFile("path_to_output_directory" + "HelloWorldDll.pdf"));
}

// You should be up and running now
