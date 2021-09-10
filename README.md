# Azure-Notification-Hubs-With-Xamarin
:alien:Send push notifications to Xamarin.Android apps using Notification Hubs:alien:

STEPS:

:bomb:Create a Firebase project and enable Firebase Cloud Messaging

:bomb:Create a notification hub

:bomb:Create a Xamarin.Android app and connect it to the notification hub

:bomb:Send test notifications from the Azure portal


1.Step:
Create a Firebase project and enable Firebase Cloud Messaging!
[Firebase](https://user-images.githubusercontent.com/75094927/132875002-d464468e-37c8-4c9f-baa8-70a9a7809582.png)

2.Step:
On the Add Firebase to your Android app page, take the following steps:
  For the Android package name, enter a name for your package. For example:
   =>  Com.Deafult.MahmutcanGonul <=
   
   ![image](https://user-images.githubusercontent.com/75094927/132875447-c8545ba2-519c-43b3-b171-a33a3f108d6d.png)


Note: How you understand your android package? 
 => You need to open your project in Visual Studio and enter android properties, than you will see package name [if you want you can change whatever you want!]:
 ![image](https://user-images.githubusercontent.com/75094927/132875589-38290a96-7604-431b-a9ff-eb5badd99fd8.png)
Select Register app.

3.Step:

Select Download google-services.json. Then save the file into the folder of your project and select Next. If you haven't created the Visual Studio project yet, you can do this step after you create the project.

![image](https://user-images.githubusercontent.com/75094927/132875973-3efdce9b-eed9-4254-846d-b999f33c634e.png)

=>Select Next.

![image](https://user-images.githubusercontent.com/75094927/132876085-c8679c3b-b78d-402d-9fb5-e3c9d01a2bc6.png)

=>Select Skip this step.

4.Step:
In the Firebase console, select the cog for your project. Then select Project Settings.
![image](https://user-images.githubusercontent.com/75094927/132876342-8f28d288-c57a-4269-9ace-4b4023434789.png)

=>If you haven't downloaded the google-services.json file, you can do download it on this page.

![image](https://user-images.githubusercontent.com/75094927/132876489-52667e0a-c380-46df-b0ae-c9c0c938cef8.png)

5.Step:

Switch to the Cloud Messaging tab at the top. Copy and save the Server key for later use. You use this value to configure your notification hub.
![image](https://user-images.githubusercontent.com/75094927/132876628-00414494-edf1-48db-bd53-eedace095e56.png)
Don't forget server key is really imported for connection our Azure Notification Hub.


Create a notification hub
We need to  create Azure Notification Hub on Azure Portal!
1.Step:
Select All services on the left menu, and then select Notification Hubs in the Mobile section. Select the star icon next to the service name to add the service to the FAVORITES section on the left menu. After you add Notification Hubs to FAVORITES, select it on the left menu.
![image](https://user-images.githubusercontent.com/75094927/132876883-28b3f131-74d3-4e2b-a87a-ff09f687163f.png)

2.Step:  

On the Notification Hubs page, select Create on the toolbar.
![image](https://user-images.githubusercontent.com/75094927/132876913-a2e7e8a3-cbbc-4f0c-bc99-dd7db18bf9dc.png)

     
3.Step:
In the Basics tab on the Notification Hub page, do the following steps:

In Subscription, select the name of the Azure subscription you want to use, and then select an existing resource group, or create a new one.

Enter a unique name for the new namespace in Namespace Details.

A namespace contains one or more notification hubs, so type a name for the hub in Notification Hub Details. Or, select an existing namespace from the drop-down.

Select a value from the Location drop-down list box. This value specifies the location in which you want to create the hub.

Select Create.

![image](https://user-images.githubusercontent.com/75094927/132877255-96b1255d-af92-446e-b1f9-3ed763c59182.png)

4.Step:
Select Notifications (the bell icon), and then select Go to resource. You can also refresh the list on the Notification Hubs page and select your hub.
![image](https://user-images.githubusercontent.com/75094927/132877324-3d08ea8d-999e-487c-b467-e240c85a195f.png)

5.Step:
!!!This part imported because we use that keys!!!

Select Access Policies from the list. Note that the two connection strings are available to you. You'll need them later to handle push notifications.

![image](https://user-images.githubusercontent.com/75094927/132877463-bdd2c805-96f0-4efb-bbc6-1a42eeb6549f.png)



Configure GCM/FCM settings for the notification hub

1.Step:
Select Google (GCM/FCM)/ in the Settings section on the left menu.

2.Step:
Enter the server key you noted down from the Google Firebase Console.

3.Step:
Select Save on the toolbar.


![image](https://user-images.githubusercontent.com/75094927/132877663-bd8d5f7a-12a7-4992-bda4-6c125d108b71.png)

Your notification hub is configured to work with FCM, and you have the connection strings to both register your app to receive notifications and to send push notifications.





Create a Xamarin.Android app and connect it to notification hub

1.Step:
In Visual Studio, open the File menu, select New, and then select Project. In the New Project window, do these steps:

Expand Installed, Visual C#, and then click Android.

Select Android App (Xamarin) from the list.

Enter a name for the project.

Select a location for the project.

Select OK

![image](https://user-images.githubusercontent.com/75094927/132878372-db7e251d-047f-4db3-85a5-4b41d90490b9.png)


2.Step:

On the New Android App dialog box, select Blank App, and select OK.

![image](https://user-images.githubusercontent.com/75094927/132878419-3ca522cc-77cb-40c5-a848-1617d4e2b08b.png)



3.Step:
In the Solution Explorer window, expand Properties, and click AndroidManifest.xml. Update the package name to match the package name you entered when adding Firebase Cloud Messaging to your project in the Google Firebase Console.

![image](https://user-images.githubusercontent.com/75094927/132878532-c79618f4-da8d-4cd3-809e-41b4552fcf25.png)



4.Step:
Set the target Android version for the project to Android 10.0 by following these steps:

Right-click your project, and select Properties.
For the Compile using Android version: (Target framework) field, select Android 10.0.
Select Yes on the message box to continue with changing the target framework.

Note: How you can change Android version?
You need to open Android Properties and go Android Manifest, change the target Android version!

![image](https://user-images.githubusercontent.com/75094927/132878843-15978d91-2749-41e9-92ae-994133c546ab.png)




5.Step:
!!! This Part very imported !!!
a.Add required NuGet packages to the project by following these steps:

b.Right-click your project, and select Manage NuGet Packages....

c.Switch to the Installed tab, select Xamarin.Android.Support.Design, and select Update in the right pane to update the package to the latest version.

d.Switch to the Browse tab. Search for Xamarin.GooglePlayServices.Base. Select Xamarin.GooglePlayServices.Base in the result list. Then, select Install.


![image](https://user-images.githubusercontent.com/75094927/132879057-f693b81d-e6d0-44c0-a979-be561c6c1393.png)


e.In the NuGet Package Manager window, search for Xamarin.Firebase.Messaging. Select Xamarin.Firebase.Messaging in the result list. Then, select Install.

f.Now, search for Xamarin.Azure.NotificationHubs.Android. Select Xamarin.Azure.NotificationHubs.Android in the result list. Then, select Install.



Add the Google Services JSON File

1.Step:
Copy the google-services.json file that you downloaded from the Google Firebase Console to the project folder.

Add google-services.json to the project.

Select google-services.json in the Solution Explorer window.

💢In the Properties pane, set the Build Action to GoogleServicesJson. If you don't see GoogleServicesJson, close Visual Studio, relaunch it, reopen the project, and retry.💢


![image](https://user-images.githubusercontent.com/75094927/132879543-a0eb1572-6408-4ffa-be20-0e260c7441e4.png)



Set up notification hubs in your project


1.Step:
If you're migrating from Google Cloud Messaging to Firebase, your project's AndroidManifest.xml file might contain an outdated GCM configuration, which may cause notification duplication. Edit the file and remove the following lines inside the <application> section, if present:
  
  <receiver
    android:name="com.google.firebase.iid.FirebaseInstanceIdInternalReceiver"
    android:exported="false" />
<receiver
    android:name="com.google.firebase.iid.FirebaseInstanceIdReceiver"
    android:exported="true"
    android:permission="com.google.android.c2dm.permission.SEND">
    <intent-filter>
        <action android:name="com.google.android.c2dm.intent.RECEIVE" />
        <action android:name="com.google.android.c2dm.intent.REGISTRATION" />
        <category android:name="${applicationId}" />
    </intent-filter>
</receiver>
  
  
  
  
  2.Step:
  
  Add that this code in your Android Manifest file:
  
<uses-permission android:name="android.permission.INTERNET" />
<uses-permission android:name="com.google.android.c2dm.permission.RECEIVE" />
<uses-permission android:name="android.permission.WAKE_LOCK" />
<uses-permission android:name="android.permission.GET_ACCOUNTS"/>
  


3.Step:
  
  
  Create a Constants.cs class for your Xamarin project and define the following constant values in the class. Replace the placeholders with your values.
  
  🥇Gather the following information for your Android app and notification hub:

Listen connection string: On the dashboard in the Azure portal, choose View connection strings. Copy the DefaultListenSharedAccessSignature connection string for this value.
Hub name: Name of your hub from the Azure portal. For example, mynotificationhub2.
	
  public static class Constants
{
	public const string ListenConnectionString = "<Listen connection string>";
    public const string NotificationHubName = "<hub name>";
}
  
  
  
 4.Step:
  
  a.Add the following using statements to MainActivity.cs:
  
	using WindowsAzure.Messaging.NotificationHubs;
  
  b.Add the following properties to the MainActivity class:
  
	internal static readonly string CHANNEL_ID = "my_notification_channel";
  
  c.In MainActivity.cs, add the following code to OnCreate after base.OnCreate(savedInstanceState):
  
	// Listen for push notifications
        NotificationHub.SetListener(new AzureListener());
        // Start the SDK
         NotificationHub.Start(this.Application, HubName, ConnectionString);
  
  
  
  d.Add a class named AzureListener to your project. Add the following using statements to AzureListener.cs.
  
  using Android.Content;
using WindowsAzure.Messaging.NotificationHubs;
  
  e.Add the following above your class declaration, and have your class inherit from Java.Lang.Object and implement the INotificationListener:
 
	public class AzureListener : Java.Lang.Object, INotificationListener
  
  f.Add the following code inside MyFirebaseMessagingService class, to process messages that are received.
  
  public void OnPushNotificationReceived(Context context, INotificationMessage message)
    {
        var intent = new Intent(this, typeof(MainActivity));
        intent.AddFlags(ActivityFlags.ClearTop);
        var pendingIntent = PendingIntent.GetActivity(this, 0, intent, PendingIntentFlags.OneShot);

        var notificationBuilder = new NotificationCompat.Builder(this, MainActivity.CHANNEL_ID);

        notificationBuilder.SetContentTitle(message.Title)
                    .SetSmallIcon(Resource.Drawable.ic_launcher)
                    .SetContentText(message.Body)
                    .SetAutoCancel(true)
                    .SetShowWhen(false)
                    .SetContentIntent(pendingIntent);

        var notificationManager = NotificationManager.FromContext(this);

        notificationManager.Notify(0, notificationBuilder.Build());
    }
  
🛰️Last Step:
  Build your project.
  Run your app on your device or loaded emulator.
  
  
  ❗Send test notification from the Azure portal❗
  You can test receiving notifications in your app with the Test Send option in the Azure portal. It sends a test push notification to your device.
  
  ![image](https://user-images.githubusercontent.com/75094927/132888316-f48e111b-9088-4dc3-95d2-95eac00d8c4a.png)


  
  ▶️ NOTE:
  ❗If this code is not working:
     
	{
	"notification":{
		"title":"Notification Hub Test Notification",
		"body":"This is a sample notification delivered by Azure Notification Hubs."
	},
	"data":{
		"property1":"value1",
		"property2":42
	}
}

	🟢You should try this code on Azure portal:
  
	{"data":{"title":"Your_Title", "message": "Your_Message", "serialNo" : "1000000"}}
  
	◀️
  
  
  
  
  That's it now your Azure Notification Hub is ready on your Xamarin Device. Result Like this:
  
  ![Azure Notification Hub  Picture](https://user-images.githubusercontent.com/75094927/132888720-930121cd-0d1d-48b4-89a1-54bc2bdf656d.png)




  
  
