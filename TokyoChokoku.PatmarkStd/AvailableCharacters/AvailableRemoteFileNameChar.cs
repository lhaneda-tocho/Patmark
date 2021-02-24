﻿using System;
using System.Text;
using System.Text.RegularExpressions;
namespace TokyoChokoku.Patmark.AvailableCharacters
{
    public static class AvailableRemoteFileNameChar
    {
        /// <summary>
        /// 動作確認用:  Console.WriteLine(reg.Match(@"abyzABYZ -_.あ")); が あ を出力すればOK.
        /// </summary>
        public static readonly Regex PatternForDetectingInvalidChars;


        static AvailableRemoteFileNameChar()
        {
            try
            {
                PatternForDetectingInvalidChars = new Regex(@"(?![a-zA-Z0-9 \-_.]).");

            } catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                throw;
            }
        }

        /// <summary>
        /// 指定された文字列に使用できない文字列がないか確かめます.
        /// </summary>
        /// <returns>使用できない文字列がなければtrue, あれば falseとなります.</returns>
        /// <param name="text">Text.</param>
        public static bool IsValid(string text)
        {
            var reg = PatternForDetectingInvalidChars;
            var ans = !reg.Match(text).Success;

            System.Diagnostics.Debug.WriteLine("Validation target text: " + text);
            System.Diagnostics.Debug.WriteLine("Validation result: " + ans);

            return ans;
        }


        /// <summary>
        /// 使用可能な文字が何か説明するためのテキストを返します.
        /// 引数にはC#のフォーマットを入力します.
        /// </summary>
        /// <returns>説明文</returns>
        /// <param name="format">フォーマット. {0}から順に "a~z", "A~Z", "-_." そして 引数 spaceL が入ります.</param>
        /// <param name="spaceL">Spaceの訳語</param>
        public static string ToStringAvailableChar(string format, string spaceL)
        {
            return String.Format(
                    format,
                    "a~z", "A~Z", "0~9", "-_.", spaceL
            );
        }
    }
}