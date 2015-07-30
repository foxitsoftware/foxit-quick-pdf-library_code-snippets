<?php
$root = $_SERVER['DOCUMENT_ROOT'] . '/'; // Root path of your site
$FileName = $root . '/hello_world.pdf'; // Specify a file name
$qp = new COM('DebenuPDFLibraryAX1115.PDFLibrary'); // Make sure you've registered the ActiveX edition of the library
$validKey = $qp->UnlockKey('...'); // Insert your license key here
if ($validKey == 1)
{
    echo 'License validation successful!';
    echo '<br />';
    echo 'Valid license key: ';
    echo $qp->LicenseInfo;
    echo '<br />';
}
else
{
    echo 'License validation failed!';
    echo '<br /><br />';
}

// This function sets the origin for the co-ordinates used by the drawing functions.
$qp->SetOrigin(1);

// The DrawText function lets you draw text onto a page.
$qp->DrawText(100, 100, 'Hello PHP! This text has been drawn using the DrawText function.');
$qp->DrawHTMLText(100, 125, 400, '<b>Debenu Quick PDF Library Version:</b> ' . $qp->LibraryVersion);
$qp->DrawHTMLText(100, 140, 400, '<b>License Information:</b> ' . $qp->LicenseInfo);

// The DrawBox function lets you draw rectangular shapes.
$qp->DrawBox(50, 50, 500, 150, 0);

// Save the file to disk
$r = $qp->SaveToFile($FileName);

if ($r == 1)
{
    echo 'The file was saved successfully.';
} elseif ($r == 2)
{
	echo 'The file was not saved successfully.';
}

$qp = null;
?>
