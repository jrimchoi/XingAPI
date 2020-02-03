﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQt1981InBlock : XingBlock
	{
		/// <summary>
		/// t1981InBlock
		/// </summary>
		static readonly string _blockName = "t1981InBlock";
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
		/// t1981InBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1981InBlock
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
		/// 시장구분(0:전체1:코스피2:코스닥)
		/// </summary>
		[XAQueryFieldAttribute("시장구분(0:전체1:코스피2:코스닥)")]
		public char mkt_gb;

		public static class F
		{
			/// <summary>
			/// 시장구분(0:전체1:코스피2:코스닥)
			/// </summary>
			public const string mkt_gb = "mkt_gb";
		}

		public static string[] AllFields = new string[]
		{
			F.mkt_gb,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["mkt_gb"] = new XAQueryFieldInfo("char", mkt_gb, mkt_gb.ToString(), "시장구분(0:전체1:코스피2:코스닥)", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "mkt_gb":
					this.mkt_gb = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			// mkt_gb char 1

			return true;
		}
	}

	public partial class XQt1981OutBlock : XingBlock
	{
		/// <summary>
		/// t1981OutBlock
		/// </summary>
		static readonly string _blockName = "t1981OutBlock";
		/// <summary>
		/// 출력1
		/// </summary>
		static readonly string _blockDesc = "출력1";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// t1981OutBlock
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1981OutBlock
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 출력1
		/// </summary>
		public string BlockDesc => _blockDesc;
		/// <summary>
		/// output
		/// </summary>
		public string BlockType => _blockType;
		/// <summary>
		/// false
		/// </summary>
		public bool HasOccurs => _hasOccurs;

		/// <summary>
		/// 코스피종목건수
		/// </summary>
		[XAQueryFieldAttribute("코스피종목건수")]
		public string ksp_cnt;
		/// <summary>
		/// 코스닥종목건수
		/// </summary>
		[XAQueryFieldAttribute("코스닥종목건수")]
		public string ksd_cnt;

		public static class F
		{
			/// <summary>
			/// 코스피종목건수
			/// </summary>
			public const string ksp_cnt = "ksp_cnt";
			/// <summary>
			/// 코스닥종목건수
			/// </summary>
			public const string ksd_cnt = "ksd_cnt";
		}

		public static string[] AllFields = new string[]
		{
			F.ksp_cnt,
			F.ksd_cnt,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["ksp_cnt"] = new XAQueryFieldInfo("char", ksp_cnt, ksp_cnt, "코스피종목건수", (decimal)4);
			dict["ksd_cnt"] = new XAQueryFieldInfo("char", ksd_cnt, ksd_cnt, "코스닥종목건수", (decimal)4);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "ksp_cnt":
					this.ksp_cnt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ksd_cnt":
					this.ksd_cnt = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQt1981OutBlock FromQuery(XQt1981 query)
		{
			XQt1981OutBlock block = new XQt1981OutBlock();
			block.IsValidData = true;
			block.InvalidReason = "";
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				block.IsValidData = false;
				block.InvalidReason = query.ReceiveMessage;
				return block;
			}
			try
			{
				block.ksp_cnt = query.GetFieldData(block.GetBlockName(), "ksp_cnt", 0).TrimEnd('?'); // char 4
				block.ksd_cnt = query.GetFieldData(block.GetBlockName(), "ksd_cnt", 0).TrimEnd('?'); // char 4

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (ksp_cnt.Length > 4) return false; // char 4
			if (ksd_cnt.Length > 4) return false; // char 4

			return true;
		}
	}

	public partial class XQt1981OutBlock1 : XingBlock
	{
		/// <summary>
		/// t1981OutBlock1
		/// </summary>
		static readonly string _blockName = "t1981OutBlock1";
		/// <summary>
		/// 출력1
		/// </summary>
		static readonly string _blockDesc = "출력1";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _hasOccurs = true;
		/// <summary>
		/// t1981OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// t1981OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// 출력1
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
		/// 단축코드
		/// </summary>
		[XAQueryFieldAttribute("단축코드")]
		public string shcode;
		/// <summary>
		/// 표준코드
		/// </summary>
		[XAQueryFieldAttribute("표준코드")]
		public string expcode;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("종목명")]
		public string hname;
		/// <summary>
		/// 현재가
		/// </summary>
		[XAQueryFieldAttribute("현재가")]
		public string price;
		/// <summary>
		/// 부호
		/// </summary>
		[XAQueryFieldAttribute("부호")]
		public char sign;
		/// <summary>
		/// 대비
		/// </summary>
		[XAQueryFieldAttribute("대비")]
		public string change;
		/// <summary>
		/// 등락율
		/// </summary>
		[XAQueryFieldAttribute("등락율")]
		public float rate;
		/// <summary>
		/// 누적거래량(주)
		/// </summary>
		[XAQueryFieldAttribute("누적거래량(주)")]
		public string volume;
		/// <summary>
		/// 누적거래대금(백만)
		/// </summary>
		[XAQueryFieldAttribute("누적거래대금(백만)")]
		public string value;
		/// <summary>
		/// 시장구분
		/// </summary>
		[XAQueryFieldAttribute("시장구분")]
		public char mkt_gb;

		public static class F
		{
			/// <summary>
			/// 단축코드
			/// </summary>
			public const string shcode = "shcode";
			/// <summary>
			/// 표준코드
			/// </summary>
			public const string expcode = "expcode";
			/// <summary>
			/// 종목명
			/// </summary>
			public const string hname = "hname";
			/// <summary>
			/// 현재가
			/// </summary>
			public const string price = "price";
			/// <summary>
			/// 부호
			/// </summary>
			public const string sign = "sign";
			/// <summary>
			/// 대비
			/// </summary>
			public const string change = "change";
			/// <summary>
			/// 등락율
			/// </summary>
			public const string rate = "rate";
			/// <summary>
			/// 누적거래량(주)
			/// </summary>
			public const string volume = "volume";
			/// <summary>
			/// 누적거래대금(백만)
			/// </summary>
			public const string value = "value";
			/// <summary>
			/// 시장구분
			/// </summary>
			public const string mkt_gb = "mkt_gb";
		}

		public static string[] AllFields = new string[]
		{
			F.shcode,
			F.expcode,
			F.hname,
			F.price,
			F.sign,
			F.change,
			F.rate,
			F.volume,
			F.value,
			F.mkt_gb,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["shcode"] = new XAQueryFieldInfo("char", shcode, shcode, "단축코드", (decimal)6);
			dict["expcode"] = new XAQueryFieldInfo("char", expcode, expcode, "표준코드", (decimal)12);
			dict["hname"] = new XAQueryFieldInfo("char", hname, hname, "종목명", (decimal)20);
			dict["price"] = new XAQueryFieldInfo("char", price, price, "현재가", (decimal)12);
			dict["sign"] = new XAQueryFieldInfo("char", sign, sign.ToString(), "부호", (decimal)1);
			dict["change"] = new XAQueryFieldInfo("char", change, change, "대비", (decimal)12);
			dict["rate"] = new XAQueryFieldInfo("float", rate, rate.ToString("00000.00"), "등락율", (decimal)5.2);
			dict["volume"] = new XAQueryFieldInfo("char", volume, volume, "누적거래량(주)", (decimal)12);
			dict["value"] = new XAQueryFieldInfo("char", value, value, "누적거래대금(백만)", (decimal)12);
			dict["mkt_gb"] = new XAQueryFieldInfo("char", mkt_gb, mkt_gb.ToString(), "시장구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "shcode":
					this.shcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "expcode":
					this.expcode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "hname":
					this.hname = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "price":
					this.price = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "sign":
					this.sign = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "change":
					this.change = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "rate":
					this.rate = fieldInfo.FieldValue.ParseFloat("rate");
				break;

				case "volume":
					this.volume = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "value":
					this.value = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "mkt_gb":
					this.mkt_gb = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQt1981OutBlock1[] ListFromQuery(XQt1981 query)
		{
			int count = query.GetBlockCount(XQt1981OutBlock1.BlockName);
			List<XQt1981OutBlock1> list = new List<XQt1981OutBlock1>();
			if (query.QueryResult != null && query.QueryResult.IsSystemError == true)
			{
				return list.ToArray();
			}
			for (int i = 0; i < count; i ++)
			{
				XQt1981OutBlock1 block = new XQt1981OutBlock1();
				block.IsValidData = true;
				block.InvalidReason = "";
				try
				{
					block.shcode = query.GetFieldData(block.GetBlockName(), "shcode", i).TrimEnd('?'); // char 6
					block.expcode = query.GetFieldData(block.GetBlockName(), "expcode", i).TrimEnd('?'); // char 12
					block.hname = query.GetFieldData(block.GetBlockName(), "hname", i).TrimEnd('?'); // char 20
					block.price = query.GetFieldData(block.GetBlockName(), "price", i).TrimEnd('?'); // char 12
					block.sign = query.GetFieldData(block.GetBlockName(), "sign", i).FirstOrDefault(); // char 1
					block.change = query.GetFieldData(block.GetBlockName(), "change", i).TrimEnd('?'); // char 12
					block.rate = query.GetFieldData(block.GetBlockName(), "rate", i).ParseFloat("rate"); // float 5.2
					block.volume = query.GetFieldData(block.GetBlockName(), "volume", i).TrimEnd('?'); // char 12
					block.value = query.GetFieldData(block.GetBlockName(), "value", i).TrimEnd('?'); // char 12
					block.mkt_gb = query.GetFieldData(block.GetBlockName(), "mkt_gb", i).FirstOrDefault(); // char 1

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
			if (shcode.Length > 6) return false; // char 6
			if (expcode.Length > 12) return false; // char 12
			if (hname.Length > 20) return false; // char 20
			if (price.Length > 12) return false; // char 12
			// sign char 1
			if (change.Length > 12) return false; // char 12
			// rate float 5.2
			if (volume.Length > 12) return false; // char 12
			if (value.Length > 12) return false; // char 12
			// mkt_gb char 1

			return true;
		}
	}

	public partial class XQt1981 : XingQuery
	{
		/// <summary>
		/// t1981
		/// </summary>
		static readonly string _typeName = "t1981";
		/// <summary>
		/// 기초자산리스트조회(t1981)
		/// </summary>
		static readonly string _typeDesc = "기초자산리스트조회(t1981)";
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
		/// t1981
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 기초자산리스트조회(t1981)
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

		public XQt1981() : base("t1981") { }


		public bool SetFields(XQt1981InBlock block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "mkt_gb", 0, block.mkt_gb.ToString()); // char 1

			return true;
		}

		public XQt1981OutBlock GetBlock()
		{
			XQt1981OutBlock instance = XQt1981OutBlock.FromQuery(this);
			return instance;

		}

		public XQt1981OutBlock1[] GetBlock1s()
		{
			XQt1981OutBlock1[] instance = XQt1981OutBlock1.ListFromQuery(this);
			return instance;

		}


	}

}
