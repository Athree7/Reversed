﻿// Decompiled with JetBrains decompiler
// Type: ERROR_408.My.MyProject
// Assembly: ERROR 408, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3A16A069-E54E-486F-B90E-25ABCEBFADB0
// Assembly location: C:\Users\user\Downloads\huherror(Fixed)\huherror\huherror.exe
// XML documentation location: C:\Users\user\Downloads\huherror(Fixed)\huherror\huherror.xml

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace ERROR_408.My
{
  [StandardModule]
  [HideModuleName]
  [GeneratedCode("MyTemplate", "11.0.0.0")]
  internal sealed class MyProject
  {
    private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
    private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
    private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

    [HelpKeyword("My.Computer")]
    internal static MyComputer Computer
    {
      [DebuggerHidden] get => MyProject.m_ComputerObjectProvider.GetInstance;
    }

    [HelpKeyword("My.Application")]
    internal static MyApplication Application
    {
      [DebuggerHidden] get => MyProject.m_AppObjectProvider.GetInstance;
    }

    [HelpKeyword("My.User")]
    internal static User User
    {
      [DebuggerHidden] get => MyProject.m_UserObjectProvider.GetInstance;
    }

    [HelpKeyword("My.Forms")]
    internal static MyProject.MyForms Forms
    {
      [DebuggerHidden] get => MyProject.m_MyFormsObjectProvider.GetInstance;
    }

    [HelpKeyword("My.WebServices")]
    internal static MyProject.MyWebServices WebServices
    {
      [DebuggerHidden] get => MyProject.m_MyWebServicesObjectProvider.GetInstance;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
    internal sealed class MyForms
    {
      [ThreadStatic]
      private static Hashtable m_FormBeingCreated;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Form1 m_Form1;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Form2 m_Form2;

      [DebuggerHidden]
      private static T Create__Instance__<T>(T Instance) where T : Form, new()
      {
        T instance;
        if ((object) Instance == null || Instance.IsDisposed)
        {
          if (MyProject.MyForms.m_FormBeingCreated != null)
          {
            if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object) typeof (T)))
              throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
          }
          else
            MyProject.MyForms.m_FormBeingCreated = new Hashtable();
          MyProject.MyForms.m_FormBeingCreated.Add((object) typeof (T), (object) null);
          TargetInvocationException invocationException;
          try
          {
            instance = new T();
          }
          catch (TargetInvocationException ex) when (
          {
            // ISSUE: unable to correctly present filter
            ProjectData.SetProjectError((Exception) ex);
            invocationException = ex;
            if (invocationException.InnerException != null)
            {
              SuccessfulFiltering;
            }
            else
              throw;
          }
          )
          {
            throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", invocationException.InnerException.Message), invocationException.InnerException);
          }
          finally
          {
            MyProject.MyForms.m_FormBeingCreated.Remove((object) typeof (T));
          }
        }
        else
          instance = Instance;
        return instance;
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) where T : Form
      {
        instance.Dispose();
        instance = default (T);
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public MyForms()
      {
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode() => base.GetHashCode();

      [EditorBrowsable(EditorBrowsableState.Never)]
      internal new System.Type GetType() => typeof (MyProject.MyForms);

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override string ToString() => base.ToString();

      public Form1 Form1
      {
        get
        {
          this.m_Form1 = MyProject.MyForms.Create__Instance__<Form1>(this.m_Form1);
          return this.m_Form1;
        }
        set
        {
          if (value == this.m_Form1)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Form1>(ref this.m_Form1);
        }
      }

      public Form2 Form2
      {
        get
        {
          this.m_Form2 = MyProject.MyForms.Create__Instance__<Form2>(this.m_Form2);
          return this.m_Form2;
        }
        set
        {
          if (value == this.m_Form2)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Form2>(ref this.m_Form2);
        }
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
    internal sealed class MyWebServices
    {
      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override int GetHashCode() => base.GetHashCode();

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      internal new System.Type GetType() => typeof (MyProject.MyWebServices);

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override string ToString() => base.ToString();

      [DebuggerHidden]
      private static T Create__Instance__<T>(T instance) where T : new()
      {
        return (object) instance != null ? instance : new T();
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) => instance = default (T);

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public MyWebServices()
      {
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [ComVisible(false)]
    internal sealed class ThreadSafeObjectProvider<T> where T : new()
    {
      internal T GetInstance
      {
        [DebuggerHidden] get
        {
          if ((object) MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
            MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
          return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
        }
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public ThreadSafeObjectProvider()
      {
      }
    }
  }
}
