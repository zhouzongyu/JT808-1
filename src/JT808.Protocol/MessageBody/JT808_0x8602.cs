﻿using JT808.Protocol.Attributes;
using JT808.Protocol.Enums;
using JT808.Protocol.JT808Properties;
using System;
using System.Collections.Generic;
using System.Text;
using JT808.Protocol.JT808Formatters.MessageBodyFormatters;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// 设置矩形区域
    /// 0x8602
    /// </summary>
    [JT808Formatter(typeof(JT808_0x8602Formatter))]
    public class JT808_0x8602:JT808Bodies
    {
        /// <summary>
        /// 设置属性
        /// </summary>
        public JT808_0x8602_SettingProperty SettingProperty { get; set; }
        /// <summary>
        /// 区域总数
        /// </summary>
        public byte AreaCount { get; set; }
        /// <summary>
        /// 区域项
        /// </summary>
        public List<JT808RectangleAreaProperty> AreaItems { get; set; }

    }
}
