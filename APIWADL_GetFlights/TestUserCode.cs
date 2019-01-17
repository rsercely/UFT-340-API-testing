namespace Script
{
    using System;
    using System.Xml;
    using System.Xml.Schema;
    using HP.ST.Ext.BasicActivities;
    using HP.ST.Fwk.RunTimeFWK;
    using HP.ST.Fwk.RunTimeFWK.ActivityFWK;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Fwk.RunTimeFWK.CompositeActivities;
	using HP.ST.Ext.CustomDataProviders.Extensions;
	using HP.ST.Ext.CustomDataProviders.ExcelFileArguments;
    
    [Serializable()]
    public class TestUserCode : TestEntities
    {
    	
    	/// <summary>
    	/// Handler for the RESTActivityV24 Activity’s AfterExecuteStepEvent event.
    	/// </summary>
    	/// <param name=\"sender\">The activity object that raised the AfterExecuteStepEvent event.</param>
    	/// <param name=\"args\">The event arguments passed to the activity.</param>
    	/// Use this.RESTActivityV24 to access the RESTActivityV24 Activity's context, including input and output properties.
    	public void RESTActivityV24_OnAfterExecuteStepEvent(object sender, STActivityBaseEventArgs args)
    	{
///    		var iResponse = this.Activity.responsebody;
///System.IO.File.WriteLines(@"directorypath&FileName);
 	///  		XmlDocument foo = this.RESTActivityV24.XMLResponse();
  ///  		int flightNo = this.RESTActivityV24.Output("GetFlights_OutputParam_FlightNo");
    		
    			
    	}

    	/// <summary>
    	/// Handler for the RESTActivityV24 Activity’s CodeCheckPointEvent event.
    	/// </summary>
    	/// <param name=\"sender\">The activity object that raised the CodeCheckPointEvent event.</param>
    	/// <param name=\"args\">The event arguments passed to the activity.</param>
    	/// Use this.RESTActivityV24 to access the RESTActivityV24 Activity's context, including input and output properties.
    	public void RESTActivityV24_OnCodeCheckPointEvent(object sender, CheckpointEventArgs args)
    	{
    		//TODO: Add your code here...
    	}
}

}
