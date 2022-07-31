using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.Loger
{
    public static class Log
    {
        public static bool IsDetailMode { get { return WLog.Log.IsDetailMode; } set { WLog.Log.IsDetailMode = value; } }

        public static LogLevel LogLevel { get; set; }

        public static bool UnAble { get { return WLog.Log.UnAble; } set { WLog.Log.UnAble = value; } }

        public static void Load(string modPath, LogLevel logLevel = LogLevel.Debug, bool DegubInterface = true, bool clearFile = true)
        {

            if (modPath != null)
                WLog.Log.Path = Path.Combine(modPath, "ABLog");

            if (clearFile)
                WLog.Log.ClearFile(true);

            if (DegubInterface)
                WLog.Log.OpenWPF(Path.Combine(modPath, @"LogInterface\Release\net6.0-windows\Wpf_DebugInfo.exe"));

            LogLevel = logLevel;
        }

        /// <summary>
        /// 写入一条Debug信息
        /// </summary>
        /// <param name="message">要写入的信息</param>
        /// <param name="callerName">调用函数的名字</param>
        /// <param name="fileName">调用文件的名字</param>
        /// <param name="line">调用时的行数</param>
        public static void Debug(
                object message = null,
                [CallerMemberName] string callerName = null,
                [CallerFilePath] string fileName = null,
                [CallerLineNumber] int line = 0)
        {
            if (LogLevel.Debug < LogLevel)
                return;

            if (message == null)
                message = "";

            WLog.Log.Debug(message, callerName, fileName, line); 
        }

        /// <summary>
        /// 写入一条Infor信息
        /// </summary>
        /// <param name="message">要写入的信息</param>
        /// <param name="callerName">调用函数的名字</param>
        /// <param name="fileName">调用文件的名字</param>
        /// <param name="line">调用时的行数</param>
        public static void Infor(
                object message = null,
                [CallerMemberName] string callerName = null,
                [CallerFilePath] string fileName = null,
                [CallerLineNumber] int line = 0)
        {
            if (LogLevel.Infor < LogLevel)
                return;

            if (message == null)
                message = "";

            WLog.Log.Infor(message, callerName, fileName, line);
        }

        /// <summary>
        /// 写入一条Error信息
        /// </summary>
        /// <param name="message">要写入的信息</param>
        /// <param name="callerName">调用函数的名字</param>
        /// <param name="fileName">调用文件的名字</param>
        /// <param name="line">调用时的行数</param>
        public static void Error(
                object message = null,
                [CallerMemberName] string callerName = null,
                [CallerFilePath] string fileName = null,
                [CallerLineNumber] int line = 0)
        {
            if (LogLevel.Error < LogLevel)
                return;

            if (message == null)
                message = "";

            WLog.Log.Error(message, callerName, fileName, line);
        }

        /// <summary>
        /// 写入一条Fatal信息
        /// </summary>
        /// <param name="message">要写入的信息</param>
        /// <param name="callerName">调用函数的名字</param>
        /// <param name="fileName">调用文件的名字</param>
        /// <param name="line">调用时的行数</param>
        public static void Fatal(
                object message = null,
                [CallerMemberName] string callerName = null,
                [CallerFilePath] string fileName = null,
                [CallerLineNumber] int line = 0)
        {
            if (LogLevel.Fatal < LogLevel)
                return;

            if (message == null)
                message = "";

            WLog.Log.Fatal(message, callerName, fileName, line);
        }
    }
}
