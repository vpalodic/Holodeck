namespace DotNetInterceptTester.My_System.ComponentModel.PropertyDescriptor
{
public class GetChildProperties_System_ComponentModel_PropertyDescriptor
{
public static bool _GetChildProperties_System_ComponentModel_PropertyDescriptor( )
{
   //Parameters

   //ReturnType/Value
   System.ComponentModel.PropertyDescriptorCollection returnVal_Real = null;
   System.ComponentModel.PropertyDescriptorCollection returnVal_Intercepted = null;

   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.ComponentModel.PropertyDescriptor.GetChildProperties();
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.ComponentModel.PropertyDescriptor.GetChildProperties();
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


   Return ( ( exception_Real.Messsage == exception_Intercepted.Message ) && ( returnValue_Real == returnValue_Intercepted ) );
}
}
}
