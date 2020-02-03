﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1531InBlock : XingBlock
	{
		/// <summary>
		/// t1531InBlock
		/// </summary>
		static readonly string _blockName = "t1531InBlock";
		/// <summary>
		/// 기본입력
		/// </summary>
		static readonly string _blockDesc = "기본입력";
		/// <summary>
		/// input
		/// </summary>
		static readonly string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// t1531InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1531InBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 기본입력
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// input
		/// </summary>
		public string BlockType => _blockType;
		/// <summary>
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 테마명
		/// </summary>
		[XAQueryFieldAttribute("테마명")]
		public string tmname;
		/// <summary>
		/// 테마코드
		/// </summary>
		[XAQueryFieldAttribute("테마코드")]
		public string tmcode;

		public static class F
		{
			/// <summary>
			/// 테마명
			/// </summary>
			public const string tmname = "tmname";
			/// <summary>
			/// 테마코드
			/// </summary>
			public const string tmcode = "tmcode";
		}

		public static string[] AllFields = new string[]
		{
			F.tmname,
			F.tmcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["tmname"] = new XAQueryFieldInfo("char", tmname, tmname, "테마명", (decimal)36);
			dict["tmcode"] = new XAQueryFieldInfo("char", tmcode, tmcode, "테마코드", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "tmname":
					this.tmname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "tmcode":
					this.tmcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public bool VerifyData()
		{
			if (tmname.Length > 36) return false; // char 36
			if (tmcode.Length > 4) return false; // char 4

			return true;
		}
	}

	public partial class XQt1531OutBlock : XingBlock
	{
		/// <summary>
		/// t1531OutBlock
		/// </summary>
		static readonly string _blockName = "t1531OutBlock";
		/// <summary>
		/// 출력
		/// </summary>
		static readonly string _blockDesc = "출력";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _hasOccurs = true;
		/// <summary>
		/// t1531OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1531OutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 출력
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;
		/// <summary>
		/// true
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 테마명
		/// </summary>
		[XAQueryFieldAttribute("테마명")]
		public string tmname;
		/// <summary>
		/// 평균등락율
		/// </summary>
		[XAQueryFieldAttribute("평균등락율")]
		public float avgdiff;
		/// <summary>
		/// 테마코드
		/// </summary>
		[XAQueryFieldAttribute("테마코드")]
		public string tmcode;

		public static class F
		{
			/// <summary>
			/// 테마명
			/// </summary>
			public const string tmname = "tmname";
			/// <summary>
			/// 평균등락율
			/// </summary>
			public const string avgdiff = "avgdiff";
			/// <summary>
			/// 테마코드
			/// </summary>
			public const string tmcode = "tmcode";
		}

		public static string[] AllFields = new string[]
		{
			F.tmname,
			F.avgdiff,
			F.tmcode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["tmname"] = new XAQueryFieldInfo("char", tmname, tmname, "테마명", (decimal)36);
			dict["avgdiff"] = new XAQueryFieldInfo("float", avgdiff, avgdiff.ToString("000000.00"), "평균등락율", (decimal)6.2);
			dict["tmcode"] = new XAQueryFieldInfo("char", tmcode, tmcode, "테마코드", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "tmname":
					this.tmname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "avgdiff":
					this.avgdiff = fieldInfo.FieldValue.ParseFloat("avgdiff");
				break;

				case "tmcode":
					this.tmcode = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1531OutBlock[] ListFromQuery(XQt1531 query)
		{
			int count = query.GetBlockCount(XQt1531OutBlock.BlockName);
			List<XQt1531OutBlock> list = new List<XQt1531OutBlock>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1531OutBlock block = new XQt1531OutBlock();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.tmname = query.GetFieldData(block.GetBlockName(), "tmname", i).TrimEnd('?'); // char 36
					block.avgdiff = query.GetFieldData(block.GetBlockName(), "avgdiff", i).ParseFloat("avgdiff"); // float 6.2
					block.tmcode = query.GetFieldData(block.GetBlockName(), "tmcode", i).TrimEnd('?'); // char 4

				} catch (InvalidDataFormatException e) {
					block.IsValidData = false;
					block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
				}
				list.Add(block);
			}
			return list.ToArray();

		}

		public bool VerifyData()
		{
			if (tmname.Length > 36) return false; // char 36
			// avgdiff float 6.2
			if (tmcode.Length > 4) return false; // char 4

			return true;
		}
	}

	public partial class XQt1531 : XingQuery
	{
		/// <summary>
		/// t1531
		/// </summary>
		static readonly string _typeName = "t1531";
		/// <summary>
		/// 테마별종목(t1531)
		/// </summary>
		static readonly string _typeDesc = "테마별종목(t1531)";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _service = "";
		/// <summary>
		/// A
		/// </summary>
		static readonly string _headType = "A";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _creator = "";
		/// <summary>
		/// 
		/// </summary>
		static readonly string _createdDate = "";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _attr = true;
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _block = true;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _encrypt = false;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _signature = false;

		/// <summary>
		/// t1531
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 테마별종목(t1531)
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// 
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// A
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 
		/// </summary>
		public string CreatedDate => _createdDate;
		/// <summary>
		/// true
		/// </summary>
		public bool Attr => _attr;
		/// <summary>
		/// true
		/// </summary>
		public bool Block => _block;
		/// <summary>
		/// false
		/// </summary>
		public bool Encrypt => _encrypt;
		/// <summary>
		/// false
		/// </summary>
		public bool Signature => _signature;

		public XQt1531() : base("t1531") { }


		public bool SetFields(XQt1531InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "tmname", 0, block.tmname); // char 36
			_xaQuery.SetFieldData(block.GetBlockName(), "tmcode", 0, block.tmcode); // char 4

			return true;
		}

		public XQt1531OutBlock[] GetBlocks()
		{
			XQt1531OutBlock[] instance = XQt1531OutBlock.ListFromQuery(this);
			return instance;

		}


	}

}
