﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class OptionProperties
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("WakeOnLan.OptionProperties", GetType(OptionProperties).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Version.
        '''</summary>
        Friend Shared ReadOnly Property AppVersion() As String
            Get
                Return ResourceManager.GetString("AppVersion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Application version.
        '''</summary>
        Friend Shared ReadOnly Property AppVersionDescription() As String
            Get
                Return ResourceManager.GetString("AppVersionDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Automatically check for updates.
        '''</summary>
        Friend Shared ReadOnly Property AutoCheck() As String
            Get
                Return ResourceManager.GetString("AutoCheck", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Broadcast Address.
        '''</summary>
        Friend Shared ReadOnly Property Broadcast_Address() As String
            Get
                Return ResourceManager.GetString("Broadcast_Address", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Enter the broadcast IP Address for the WOL broadcast packets..
        '''</summary>
        Friend Shared ReadOnly Property Broadcast_AddressDescription() As String
            Get
                Return ResourceManager.GetString("Broadcast_AddressDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Application.
        '''</summary>
        Friend Shared ReadOnly Property cat_Application() As String
            Get
                Return ResourceManager.GetString("cat_Application", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Emergency settings.
        '''</summary>
        Friend Shared ReadOnly Property cat_Emergency() As String
            Get
                Return ResourceManager.GetString("cat_Emergency", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Shutdown.
        '''</summary>
        Friend Shared ReadOnly Property cat_Shutdown() As String
            Get
                Return ResourceManager.GetString("cat_Shutdown", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to WOL.
        '''</summary>
        Friend Shared ReadOnly Property cat_WOL() As String
            Get
                Return ResourceManager.GetString("cat_WOL", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Database path.
        '''</summary>
        Friend Shared ReadOnly Property dbPath() As String
            Get
                Return ResourceManager.GetString("dbPath", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Time delay.
        '''</summary>
        Friend Shared ReadOnly Property Delay() As String
            Get
                Return ResourceManager.GetString("Delay", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The default time delay for shutdowns..
        '''</summary>
        Friend Shared ReadOnly Property DelayDescription() As String
            Get
                Return ResourceManager.GetString("DelayDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Time delay.
        '''</summary>
        Friend Shared ReadOnly Property EmergencyDelay() As String
            Get
                Return ResourceManager.GetString("EmergencyDelay", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The time delay for emergency shutdowns..
        '''</summary>
        Friend Shared ReadOnly Property EmergencyDelayDescription() As String
            Get
                Return ResourceManager.GetString("EmergencyDelayDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Default Message.
        '''</summary>
        Friend Shared ReadOnly Property EmergencyShutdown() As String
            Get
                Return ResourceManager.GetString("EmergencyShutdown", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The emergency shutdown message..
        '''</summary>
        Friend Shared ReadOnly Property EmergencyShutdownDescription() As String
            Get
                Return ResourceManager.GetString("EmergencyShutdownDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Enable sound.
        '''</summary>
        Friend Shared ReadOnly Property Enable_Sound() As String
            Get
                Return ResourceManager.GetString("Enable_Sound", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Play a sound when a monitored server comes online, or stops responding..
        '''</summary>
        Friend Shared ReadOnly Property Enable_SoundDescription() As String
            Get
                Return ResourceManager.GetString("Enable_SoundDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Force shutdown.
        '''</summary>
        Friend Shared ReadOnly Property Force() As String
            Get
                Return ResourceManager.GetString("Force", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Force remote server to shutdown.  Unsaved files will be lost..
        '''</summary>
        Friend Shared ReadOnly Property ForceDescription() As String
            Get
                Return ResourceManager.GetString("ForceDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Language.
        '''</summary>
        Friend Shared ReadOnly Property Language() As String
            Get
                Return ResourceManager.GetString("Language", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Reboot.
        '''</summary>
        Friend Shared ReadOnly Property Reboot() As String
            Get
                Return ResourceManager.GetString("Reboot", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to If true, then reboot after shutdown..
        '''</summary>
        Friend Shared ReadOnly Property RebootDescription() As String
            Get
                Return ResourceManager.GetString("RebootDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Default Message.
        '''</summary>
        Friend Shared ReadOnly Property Shutdown() As String
            Get
                Return ResourceManager.GetString("Shutdown", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The default shutdown message..
        '''</summary>
        Friend Shared ReadOnly Property ShutdownDescription() As String
            Get
                Return ResourceManager.GetString("ShutdownDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Number of threads.
        '''</summary>
        Friend Shared ReadOnly Property Threads() As String
            Get
                Return ResourceManager.GetString("Threads", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to UDP Port.
        '''</summary>
        Friend Shared ReadOnly Property UDPPort() As String
            Get
                Return ResourceManager.GetString("UDPPort", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Enter the UDP Port number for the broadcast messages..
        '''</summary>
        Friend Shared ReadOnly Property UDPPortDescription() As String
            Get
                Return ResourceManager.GetString("UDPPortDescription", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
