namespace DotNetInterceptTester.My_System.ComponentModel.LicFileLicenseProvider
{
public class ctor_System_ComponentModel_LicFileLicenseProvider
{
public static bool _ctor_System_ComponentModel_LicFileLicenseProvider( )
{
   //Parameters


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.ComponentModel.LicFileLicenseProvider.ctor();
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.ComponentModel.LicFileLicenseProvider.ctor();
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}
