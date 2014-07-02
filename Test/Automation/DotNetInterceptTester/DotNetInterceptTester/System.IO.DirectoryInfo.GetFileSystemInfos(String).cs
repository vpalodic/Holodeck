namespace DotNetInterceptTester.My_System.IO.DirectoryInfo
{
public class GetFileSystemInfos_System_IO_DirectoryInfo_System_String
{
public static bool _GetFileSystemInfos_System_IO_DirectoryInfo_System_String( )
{
   //Parameters
   System.String searchPattern = null;

   //ReturnType/Value
   System.IO.FileSystemInfo[] returnVal_Real = null;
   System.IO.FileSystemInfo[] returnVal_Intercepted = null;

   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.IO.DirectoryInfo.GetFileSystemInfos(searchPattern);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.IO.DirectoryInfo.GetFileSystemInfos(searchPattern);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


   Return ( ( exception_Real.Messsage == exception_Intercepted.Message ) && ( returnValue_Real == returnValue_Intercepted ) );
}
}
}