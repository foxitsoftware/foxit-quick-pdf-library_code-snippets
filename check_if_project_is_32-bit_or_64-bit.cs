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
