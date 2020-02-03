﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XingAPINet;

namespace XingAPINet
{
	public partial class XQCSPAT00600InBlock1 : XingBlock
	{
		/// <summary>
		/// CSPAT00600InBlock1
		/// </summary>
		static readonly string _blockName = "CSPAT00600InBlock1";
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		static readonly string _blockDesc = "In(*EMPTY*)";
		/// <summary>
		/// input
		/// </summary>
		static readonly string _blockType = "input";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// CSPAT00600InBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAT00600InBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// In(*EMPTY*)
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
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string AcntNo;
		/// <summary>
		/// 입력비밀번호
		/// </summary>
		[XAQueryFieldAttribute("입력비밀번호")]
		public string InptPwd;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("종목번호")]
		public string IsuNo;
		/// <summary>
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("주문수량")]
		public long OrdQty;
		/// <summary>
		/// 주문가
		/// </summary>
		[XAQueryFieldAttribute("주문가")]
		public double OrdPrc;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public char BnsTpCode;
		/// <summary>
		/// 호가유형코드
		/// </summary>
		[XAQueryFieldAttribute("호가유형코드")]
		public string OrdprcPtnCode;
		/// <summary>
		/// 신용거래코드
		/// </summary>
		[XAQueryFieldAttribute("신용거래코드")]
		public string MgntrnCode;
		/// <summary>
		/// 대출일
		/// </summary>
		[XAQueryFieldAttribute("대출일")]
		public string LoanDt;
		/// <summary>
		/// 주문조건구분
		/// </summary>
		[XAQueryFieldAttribute("주문조건구분")]
		public char OrdCndiTpCode;

		public static class F
		{
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string AcntNo = "AcntNo";
			/// <summary>
			/// 입력비밀번호
			/// </summary>
			public const string InptPwd = "InptPwd";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string IsuNo = "IsuNo";
			/// <summary>
			/// 주문수량
			/// </summary>
			public const string OrdQty = "OrdQty";
			/// <summary>
			/// 주문가
			/// </summary>
			public const string OrdPrc = "OrdPrc";
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string BnsTpCode = "BnsTpCode";
			/// <summary>
			/// 호가유형코드
			/// </summary>
			public const string OrdprcPtnCode = "OrdprcPtnCode";
			/// <summary>
			/// 신용거래코드
			/// </summary>
			public const string MgntrnCode = "MgntrnCode";
			/// <summary>
			/// 대출일
			/// </summary>
			public const string LoanDt = "LoanDt";
			/// <summary>
			/// 주문조건구분
			/// </summary>
			public const string OrdCndiTpCode = "OrdCndiTpCode";
		}

		public static string[] AllFields = new string[]
		{
			F.AcntNo,
			F.InptPwd,
			F.IsuNo,
			F.OrdQty,
			F.OrdPrc,
			F.BnsTpCode,
			F.OrdprcPtnCode,
			F.MgntrnCode,
			F.LoanDt,
			F.OrdCndiTpCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["InptPwd"] = new XAQueryFieldInfo("char", InptPwd, InptPwd, "입력비밀번호", (decimal)8);
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["OrdQty"] = new XAQueryFieldInfo("long", OrdQty, OrdQty.ToString("d16"), "주문수량", (decimal)16);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("0000000000000.00"), "주문가", (decimal)13.2);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["OrdprcPtnCode"] = new XAQueryFieldInfo("char", OrdprcPtnCode, OrdprcPtnCode, "호가유형코드", (decimal)2);
			dict["MgntrnCode"] = new XAQueryFieldInfo("char", MgntrnCode, MgntrnCode, "신용거래코드", (decimal)3);
			dict["LoanDt"] = new XAQueryFieldInfo("char", LoanDt, LoanDt, "대출일", (decimal)8);
			dict["OrdCndiTpCode"] = new XAQueryFieldInfo("char", OrdCndiTpCode, OrdCndiTpCode.ToString(), "주문조건구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "AcntNo":
					this.AcntNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "InptPwd":
					this.InptPwd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuNo":
					this.IsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdQty":
					this.OrdQty = fieldInfo.FieldValue.ParseLong("OrdQty");
				break;

				case "OrdPrc":
					this.OrdPrc = fieldInfo.FieldValue.ParseDouble("OrdPrc");
				break;

				case "BnsTpCode":
					this.BnsTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "OrdprcPtnCode":
					this.OrdprcPtnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "MgntrnCode":
					this.MgntrnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "LoanDt":
					this.LoanDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdCndiTpCode":
					this.OrdCndiTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public bool VerifyData()
		{
			if (AcntNo.Length > 20) return false; // char 20
			if (InptPwd.Length > 8) return false; // char 8
			if (IsuNo.Length > 12) return false; // char 12
			if (OrdQty.ToString().Length > 16) return false; // long 16
			// OrdPrc double 13.2
			// BnsTpCode char 1
			if (OrdprcPtnCode.Length > 2) return false; // char 2
			if (MgntrnCode.Length > 3) return false; // char 3
			if (LoanDt.Length > 8) return false; // char 8
			// OrdCndiTpCode char 1

			return true;
		}
	}

	public partial class XQCSPAT00600OutBlock1 : XingBlock
	{
		/// <summary>
		/// CSPAT00600OutBlock1
		/// </summary>
		static readonly string _blockName = "CSPAT00600OutBlock1";
		/// <summary>
		/// In(*EMPTY*)
		/// </summary>
		static readonly string _blockDesc = "In(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// CSPAT00600OutBlock1
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAT00600OutBlock1
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// In(*EMPTY*)
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
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("레코드갯수")]
		public long RecCnt;
		/// <summary>
		/// 계좌번호
		/// </summary>
		[XAQueryFieldAttribute("계좌번호")]
		public string AcntNo;
		/// <summary>
		/// 입력비밀번호
		/// </summary>
		[XAQueryFieldAttribute("입력비밀번호")]
		public string InptPwd;
		/// <summary>
		/// 종목번호
		/// </summary>
		[XAQueryFieldAttribute("종목번호")]
		public string IsuNo;
		/// <summary>
		/// 주문수량
		/// </summary>
		[XAQueryFieldAttribute("주문수량")]
		public long OrdQty;
		/// <summary>
		/// 주문가
		/// </summary>
		[XAQueryFieldAttribute("주문가")]
		public double OrdPrc;
		/// <summary>
		/// 매매구분
		/// </summary>
		[XAQueryFieldAttribute("매매구분")]
		public char BnsTpCode;
		/// <summary>
		/// 호가유형코드
		/// </summary>
		[XAQueryFieldAttribute("호가유형코드")]
		public string OrdprcPtnCode;
		/// <summary>
		/// 프로그램호가유형코드
		/// </summary>
		[XAQueryFieldAttribute("프로그램호가유형코드")]
		public string PrgmOrdprcPtnCode;
		/// <summary>
		/// 공매도가능여부
		/// </summary>
		[XAQueryFieldAttribute("공매도가능여부")]
		public char StslAbleYn;
		/// <summary>
		/// 공매도호가구분
		/// </summary>
		[XAQueryFieldAttribute("공매도호가구분")]
		public char StslOrdprcTpCode;
		/// <summary>
		/// 통신매체코드
		/// </summary>
		[XAQueryFieldAttribute("통신매체코드")]
		public string CommdaCode;
		/// <summary>
		/// 신용거래코드
		/// </summary>
		[XAQueryFieldAttribute("신용거래코드")]
		public string MgntrnCode;
		/// <summary>
		/// 대출일
		/// </summary>
		[XAQueryFieldAttribute("대출일")]
		public string LoanDt;
		/// <summary>
		/// 회원번호
		/// </summary>
		[XAQueryFieldAttribute("회원번호")]
		public string MbrNo;
		/// <summary>
		/// 주문조건구분
		/// </summary>
		[XAQueryFieldAttribute("주문조건구분")]
		public char OrdCndiTpCode;
		/// <summary>
		/// 전략코드
		/// </summary>
		[XAQueryFieldAttribute("전략코드")]
		public string StrtgCode;
		/// <summary>
		/// 그룹ID
		/// </summary>
		[XAQueryFieldAttribute("그룹ID")]
		public string GrpId;
		/// <summary>
		/// 주문회차
		/// </summary>
		[XAQueryFieldAttribute("주문회차")]
		public long OrdSeqNo;
		/// <summary>
		/// 포트폴리오번호
		/// </summary>
		[XAQueryFieldAttribute("포트폴리오번호")]
		public long PtflNo;
		/// <summary>
		/// 바스켓번호
		/// </summary>
		[XAQueryFieldAttribute("바스켓번호")]
		public long BskNo;
		/// <summary>
		/// 트렌치번호
		/// </summary>
		[XAQueryFieldAttribute("트렌치번호")]
		public long TrchNo;
		/// <summary>
		/// 아이템번호
		/// </summary>
		[XAQueryFieldAttribute("아이템번호")]
		public long ItemNo;
		/// <summary>
		/// 운용지시번호
		/// </summary>
		[XAQueryFieldAttribute("운용지시번호")]
		public string OpDrtnNo;
		/// <summary>
		/// 유동성공급자여부
		/// </summary>
		[XAQueryFieldAttribute("유동성공급자여부")]
		public char LpYn;
		/// <summary>
		/// 반대매매구분
		/// </summary>
		[XAQueryFieldAttribute("반대매매구분")]
		public char CvrgTpCode;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 계좌번호
			/// </summary>
			public const string AcntNo = "AcntNo";
			/// <summary>
			/// 입력비밀번호
			/// </summary>
			public const string InptPwd = "InptPwd";
			/// <summary>
			/// 종목번호
			/// </summary>
			public const string IsuNo = "IsuNo";
			/// <summary>
			/// 주문수량
			/// </summary>
			public const string OrdQty = "OrdQty";
			/// <summary>
			/// 주문가
			/// </summary>
			public const string OrdPrc = "OrdPrc";
			/// <summary>
			/// 매매구분
			/// </summary>
			public const string BnsTpCode = "BnsTpCode";
			/// <summary>
			/// 호가유형코드
			/// </summary>
			public const string OrdprcPtnCode = "OrdprcPtnCode";
			/// <summary>
			/// 프로그램호가유형코드
			/// </summary>
			public const string PrgmOrdprcPtnCode = "PrgmOrdprcPtnCode";
			/// <summary>
			/// 공매도가능여부
			/// </summary>
			public const string StslAbleYn = "StslAbleYn";
			/// <summary>
			/// 공매도호가구분
			/// </summary>
			public const string StslOrdprcTpCode = "StslOrdprcTpCode";
			/// <summary>
			/// 통신매체코드
			/// </summary>
			public const string CommdaCode = "CommdaCode";
			/// <summary>
			/// 신용거래코드
			/// </summary>
			public const string MgntrnCode = "MgntrnCode";
			/// <summary>
			/// 대출일
			/// </summary>
			public const string LoanDt = "LoanDt";
			/// <summary>
			/// 회원번호
			/// </summary>
			public const string MbrNo = "MbrNo";
			/// <summary>
			/// 주문조건구분
			/// </summary>
			public const string OrdCndiTpCode = "OrdCndiTpCode";
			/// <summary>
			/// 전략코드
			/// </summary>
			public const string StrtgCode = "StrtgCode";
			/// <summary>
			/// 그룹ID
			/// </summary>
			public const string GrpId = "GrpId";
			/// <summary>
			/// 주문회차
			/// </summary>
			public const string OrdSeqNo = "OrdSeqNo";
			/// <summary>
			/// 포트폴리오번호
			/// </summary>
			public const string PtflNo = "PtflNo";
			/// <summary>
			/// 바스켓번호
			/// </summary>
			public const string BskNo = "BskNo";
			/// <summary>
			/// 트렌치번호
			/// </summary>
			public const string TrchNo = "TrchNo";
			/// <summary>
			/// 아이템번호
			/// </summary>
			public const string ItemNo = "ItemNo";
			/// <summary>
			/// 운용지시번호
			/// </summary>
			public const string OpDrtnNo = "OpDrtnNo";
			/// <summary>
			/// 유동성공급자여부
			/// </summary>
			public const string LpYn = "LpYn";
			/// <summary>
			/// 반대매매구분
			/// </summary>
			public const string CvrgTpCode = "CvrgTpCode";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.AcntNo,
			F.InptPwd,
			F.IsuNo,
			F.OrdQty,
			F.OrdPrc,
			F.BnsTpCode,
			F.OrdprcPtnCode,
			F.PrgmOrdprcPtnCode,
			F.StslAbleYn,
			F.StslOrdprcTpCode,
			F.CommdaCode,
			F.MgntrnCode,
			F.LoanDt,
			F.MbrNo,
			F.OrdCndiTpCode,
			F.StrtgCode,
			F.GrpId,
			F.OrdSeqNo,
			F.PtflNo,
			F.BskNo,
			F.TrchNo,
			F.ItemNo,
			F.OpDrtnNo,
			F.LpYn,
			F.CvrgTpCode,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["AcntNo"] = new XAQueryFieldInfo("char", AcntNo, AcntNo, "계좌번호", (decimal)20);
			dict["InptPwd"] = new XAQueryFieldInfo("char", InptPwd, InptPwd, "입력비밀번호", (decimal)8);
			dict["IsuNo"] = new XAQueryFieldInfo("char", IsuNo, IsuNo, "종목번호", (decimal)12);
			dict["OrdQty"] = new XAQueryFieldInfo("long", OrdQty, OrdQty.ToString("d16"), "주문수량", (decimal)16);
			dict["OrdPrc"] = new XAQueryFieldInfo("double", OrdPrc, OrdPrc.ToString("0000000000000.00"), "주문가", (decimal)13.2);
			dict["BnsTpCode"] = new XAQueryFieldInfo("char", BnsTpCode, BnsTpCode.ToString(), "매매구분", (decimal)1);
			dict["OrdprcPtnCode"] = new XAQueryFieldInfo("char", OrdprcPtnCode, OrdprcPtnCode, "호가유형코드", (decimal)2);
			dict["PrgmOrdprcPtnCode"] = new XAQueryFieldInfo("char", PrgmOrdprcPtnCode, PrgmOrdprcPtnCode, "프로그램호가유형코드", (decimal)2);
			dict["StslAbleYn"] = new XAQueryFieldInfo("char", StslAbleYn, StslAbleYn.ToString(), "공매도가능여부", (decimal)1);
			dict["StslOrdprcTpCode"] = new XAQueryFieldInfo("char", StslOrdprcTpCode, StslOrdprcTpCode.ToString(), "공매도호가구분", (decimal)1);
			dict["CommdaCode"] = new XAQueryFieldInfo("char", CommdaCode, CommdaCode, "통신매체코드", (decimal)2);
			dict["MgntrnCode"] = new XAQueryFieldInfo("char", MgntrnCode, MgntrnCode, "신용거래코드", (decimal)3);
			dict["LoanDt"] = new XAQueryFieldInfo("char", LoanDt, LoanDt, "대출일", (decimal)8);
			dict["MbrNo"] = new XAQueryFieldInfo("char", MbrNo, MbrNo, "회원번호", (decimal)3);
			dict["OrdCndiTpCode"] = new XAQueryFieldInfo("char", OrdCndiTpCode, OrdCndiTpCode.ToString(), "주문조건구분", (decimal)1);
			dict["StrtgCode"] = new XAQueryFieldInfo("char", StrtgCode, StrtgCode, "전략코드", (decimal)6);
			dict["GrpId"] = new XAQueryFieldInfo("char", GrpId, GrpId, "그룹ID", (decimal)20);
			dict["OrdSeqNo"] = new XAQueryFieldInfo("long", OrdSeqNo, OrdSeqNo.ToString("d10"), "주문회차", (decimal)10);
			dict["PtflNo"] = new XAQueryFieldInfo("long", PtflNo, PtflNo.ToString("d10"), "포트폴리오번호", (decimal)10);
			dict["BskNo"] = new XAQueryFieldInfo("long", BskNo, BskNo.ToString("d10"), "바스켓번호", (decimal)10);
			dict["TrchNo"] = new XAQueryFieldInfo("long", TrchNo, TrchNo.ToString("d10"), "트렌치번호", (decimal)10);
			dict["ItemNo"] = new XAQueryFieldInfo("long", ItemNo, ItemNo.ToString("d10"), "아이템번호", (decimal)10);
			dict["OpDrtnNo"] = new XAQueryFieldInfo("char", OpDrtnNo, OpDrtnNo, "운용지시번호", (decimal)12);
			dict["LpYn"] = new XAQueryFieldInfo("char", LpYn, LpYn.ToString(), "유동성공급자여부", (decimal)1);
			dict["CvrgTpCode"] = new XAQueryFieldInfo("char", CvrgTpCode, CvrgTpCode.ToString(), "반대매매구분", (decimal)1);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "AcntNo":
					this.AcntNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "InptPwd":
					this.InptPwd = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuNo":
					this.IsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdQty":
					this.OrdQty = fieldInfo.FieldValue.ParseLong("OrdQty");
				break;

				case "OrdPrc":
					this.OrdPrc = fieldInfo.FieldValue.ParseDouble("OrdPrc");
				break;

				case "BnsTpCode":
					this.BnsTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "OrdprcPtnCode":
					this.OrdprcPtnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "PrgmOrdprcPtnCode":
					this.PrgmOrdprcPtnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "StslAbleYn":
					this.StslAbleYn = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "StslOrdprcTpCode":
					this.StslOrdprcTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "CommdaCode":
					this.CommdaCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "MgntrnCode":
					this.MgntrnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "LoanDt":
					this.LoanDt = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "MbrNo":
					this.MbrNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdCndiTpCode":
					this.OrdCndiTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "StrtgCode":
					this.StrtgCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "GrpId":
					this.GrpId = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdSeqNo":
					this.OrdSeqNo = fieldInfo.FieldValue.ParseLong("OrdSeqNo");
				break;

				case "PtflNo":
					this.PtflNo = fieldInfo.FieldValue.ParseLong("PtflNo");
				break;

				case "BskNo":
					this.BskNo = fieldInfo.FieldValue.ParseLong("BskNo");
				break;

				case "TrchNo":
					this.TrchNo = fieldInfo.FieldValue.ParseLong("TrchNo");
				break;

				case "ItemNo":
					this.ItemNo = fieldInfo.FieldValue.ParseLong("ItemNo");
				break;

				case "OpDrtnNo":
					this.OpDrtnNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "LpYn":
					this.LpYn = fieldInfo.FieldValue.FirstOrDefault();
				break;

				case "CvrgTpCode":
					this.CvrgTpCode = fieldInfo.FieldValue.FirstOrDefault();
				break;


			}
		}

		public static XQCSPAT00600OutBlock1 FromQuery(XQCSPAT00600 query)
		{
			XQCSPAT00600OutBlock1 block = new XQCSPAT00600OutBlock1();
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
				block.RecCnt = query.GetFieldData(block.GetBlockName(), "RecCnt", 0).ParseLong("RecCnt"); // long 5
				block.AcntNo = query.GetFieldData(block.GetBlockName(), "AcntNo", 0).TrimEnd('?'); // char 20
				block.InptPwd = query.GetFieldData(block.GetBlockName(), "InptPwd", 0).TrimEnd('?'); // char 8
				block.IsuNo = query.GetFieldData(block.GetBlockName(), "IsuNo", 0).TrimEnd('?'); // char 12
				block.OrdQty = query.GetFieldData(block.GetBlockName(), "OrdQty", 0).ParseLong("OrdQty"); // long 16
				block.OrdPrc = query.GetFieldData(block.GetBlockName(), "OrdPrc", 0).ParseDouble("OrdPrc"); // double 13.2
				block.BnsTpCode = query.GetFieldData(block.GetBlockName(), "BnsTpCode", 0).FirstOrDefault(); // char 1
				block.OrdprcPtnCode = query.GetFieldData(block.GetBlockName(), "OrdprcPtnCode", 0).TrimEnd('?'); // char 2
				block.PrgmOrdprcPtnCode = query.GetFieldData(block.GetBlockName(), "PrgmOrdprcPtnCode", 0).TrimEnd('?'); // char 2
				block.StslAbleYn = query.GetFieldData(block.GetBlockName(), "StslAbleYn", 0).FirstOrDefault(); // char 1
				block.StslOrdprcTpCode = query.GetFieldData(block.GetBlockName(), "StslOrdprcTpCode", 0).FirstOrDefault(); // char 1
				block.CommdaCode = query.GetFieldData(block.GetBlockName(), "CommdaCode", 0).TrimEnd('?'); // char 2
				block.MgntrnCode = query.GetFieldData(block.GetBlockName(), "MgntrnCode", 0).TrimEnd('?'); // char 3
				block.LoanDt = query.GetFieldData(block.GetBlockName(), "LoanDt", 0).TrimEnd('?'); // char 8
				block.MbrNo = query.GetFieldData(block.GetBlockName(), "MbrNo", 0).TrimEnd('?'); // char 3
				block.OrdCndiTpCode = query.GetFieldData(block.GetBlockName(), "OrdCndiTpCode", 0).FirstOrDefault(); // char 1
				block.StrtgCode = query.GetFieldData(block.GetBlockName(), "StrtgCode", 0).TrimEnd('?'); // char 6
				block.GrpId = query.GetFieldData(block.GetBlockName(), "GrpId", 0).TrimEnd('?'); // char 20
				block.OrdSeqNo = query.GetFieldData(block.GetBlockName(), "OrdSeqNo", 0).ParseLong("OrdSeqNo"); // long 10
				block.PtflNo = query.GetFieldData(block.GetBlockName(), "PtflNo", 0).ParseLong("PtflNo"); // long 10
				block.BskNo = query.GetFieldData(block.GetBlockName(), "BskNo", 0).ParseLong("BskNo"); // long 10
				block.TrchNo = query.GetFieldData(block.GetBlockName(), "TrchNo", 0).ParseLong("TrchNo"); // long 10
				block.ItemNo = query.GetFieldData(block.GetBlockName(), "ItemNo", 0).ParseLong("ItemNo"); // long 10
				block.OpDrtnNo = query.GetFieldData(block.GetBlockName(), "OpDrtnNo", 0).TrimEnd('?'); // char 12
				block.LpYn = query.GetFieldData(block.GetBlockName(), "LpYn", 0).FirstOrDefault(); // char 1
				block.CvrgTpCode = query.GetFieldData(block.GetBlockName(), "CvrgTpCode", 0).FirstOrDefault(); // char 1

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (AcntNo.Length > 20) return false; // char 20
			if (InptPwd.Length > 8) return false; // char 8
			if (IsuNo.Length > 12) return false; // char 12
			if (OrdQty.ToString().Length > 16) return false; // long 16
			// OrdPrc double 13.2
			// BnsTpCode char 1
			if (OrdprcPtnCode.Length > 2) return false; // char 2
			if (PrgmOrdprcPtnCode.Length > 2) return false; // char 2
			// StslAbleYn char 1
			// StslOrdprcTpCode char 1
			if (CommdaCode.Length > 2) return false; // char 2
			if (MgntrnCode.Length > 3) return false; // char 3
			if (LoanDt.Length > 8) return false; // char 8
			if (MbrNo.Length > 3) return false; // char 3
			// OrdCndiTpCode char 1
			if (StrtgCode.Length > 6) return false; // char 6
			if (GrpId.Length > 20) return false; // char 20
			if (OrdSeqNo.ToString().Length > 10) return false; // long 10
			if (PtflNo.ToString().Length > 10) return false; // long 10
			if (BskNo.ToString().Length > 10) return false; // long 10
			if (TrchNo.ToString().Length > 10) return false; // long 10
			if (ItemNo.ToString().Length > 10) return false; // long 10
			if (OpDrtnNo.Length > 12) return false; // char 12
			// LpYn char 1
			// CvrgTpCode char 1

			return true;
		}
	}

	public partial class XQCSPAT00600OutBlock2 : XingBlock
	{
		/// <summary>
		/// CSPAT00600OutBlock2
		/// </summary>
		static readonly string _blockName = "CSPAT00600OutBlock2";
		/// <summary>
		/// Out(*EMPTY*)
		/// </summary>
		static readonly string _blockDesc = "Out(*EMPTY*)";
		/// <summary>
		/// output
		/// </summary>
		static readonly string _blockType = "output";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _hasOccurs = false;
		/// <summary>
		/// CSPAT00600OutBlock2
		/// </summary>
		public override string GetBlockName() => _blockName;
		/// <summary>
		/// CSPAT00600OutBlock2
		/// </summary>
		public static string BlockName => _blockName;
		/// <summary>
		/// Out(*EMPTY*)
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
		/// 레코드갯수
		/// </summary>
		[XAQueryFieldAttribute("레코드갯수")]
		public long RecCnt;
		/// <summary>
		/// 주문번호
		/// </summary>
		[XAQueryFieldAttribute("주문번호")]
		public long OrdNo;
		/// <summary>
		/// 주문시각
		/// </summary>
		[XAQueryFieldAttribute("주문시각")]
		public string OrdTime;
		/// <summary>
		/// 주문시장코드
		/// </summary>
		[XAQueryFieldAttribute("주문시장코드")]
		public string OrdMktCode;
		/// <summary>
		/// 주문유형코드
		/// </summary>
		[XAQueryFieldAttribute("주문유형코드")]
		public string OrdPtnCode;
		/// <summary>
		/// 단축종목번호
		/// </summary>
		[XAQueryFieldAttribute("단축종목번호")]
		public string ShtnIsuNo;
		/// <summary>
		/// 관리사원번호
		/// </summary>
		[XAQueryFieldAttribute("관리사원번호")]
		public string MgempNo;
		/// <summary>
		/// 주문금액
		/// </summary>
		[XAQueryFieldAttribute("주문금액")]
		public long OrdAmt;
		/// <summary>
		/// 예비주문번호
		/// </summary>
		[XAQueryFieldAttribute("예비주문번호")]
		public long SpareOrdNo;
		/// <summary>
		/// 반대매매일련번호
		/// </summary>
		[XAQueryFieldAttribute("반대매매일련번호")]
		public long CvrgSeqno;
		/// <summary>
		/// 예약주문번호
		/// </summary>
		[XAQueryFieldAttribute("예약주문번호")]
		public long RsvOrdNo;
		/// <summary>
		/// 실물주문수량
		/// </summary>
		[XAQueryFieldAttribute("실물주문수량")]
		public long SpotOrdQty;
		/// <summary>
		/// 재사용주문수량
		/// </summary>
		[XAQueryFieldAttribute("재사용주문수량")]
		public long RuseOrdQty;
		/// <summary>
		/// 현금주문금액
		/// </summary>
		[XAQueryFieldAttribute("현금주문금액")]
		public long MnyOrdAmt;
		/// <summary>
		/// 대용주문금액
		/// </summary>
		[XAQueryFieldAttribute("대용주문금액")]
		public long SubstOrdAmt;
		/// <summary>
		/// 재사용주문금액
		/// </summary>
		[XAQueryFieldAttribute("재사용주문금액")]
		public long RuseOrdAmt;
		/// <summary>
		/// 계좌명
		/// </summary>
		[XAQueryFieldAttribute("계좌명")]
		public string AcntNm;
		/// <summary>
		/// 종목명
		/// </summary>
		[XAQueryFieldAttribute("종목명")]
		public string IsuNm;

		public static class F
		{
			/// <summary>
			/// 레코드갯수
			/// </summary>
			public const string RecCnt = "RecCnt";
			/// <summary>
			/// 주문번호
			/// </summary>
			public const string OrdNo = "OrdNo";
			/// <summary>
			/// 주문시각
			/// </summary>
			public const string OrdTime = "OrdTime";
			/// <summary>
			/// 주문시장코드
			/// </summary>
			public const string OrdMktCode = "OrdMktCode";
			/// <summary>
			/// 주문유형코드
			/// </summary>
			public const string OrdPtnCode = "OrdPtnCode";
			/// <summary>
			/// 단축종목번호
			/// </summary>
			public const string ShtnIsuNo = "ShtnIsuNo";
			/// <summary>
			/// 관리사원번호
			/// </summary>
			public const string MgempNo = "MgempNo";
			/// <summary>
			/// 주문금액
			/// </summary>
			public const string OrdAmt = "OrdAmt";
			/// <summary>
			/// 예비주문번호
			/// </summary>
			public const string SpareOrdNo = "SpareOrdNo";
			/// <summary>
			/// 반대매매일련번호
			/// </summary>
			public const string CvrgSeqno = "CvrgSeqno";
			/// <summary>
			/// 예약주문번호
			/// </summary>
			public const string RsvOrdNo = "RsvOrdNo";
			/// <summary>
			/// 실물주문수량
			/// </summary>
			public const string SpotOrdQty = "SpotOrdQty";
			/// <summary>
			/// 재사용주문수량
			/// </summary>
			public const string RuseOrdQty = "RuseOrdQty";
			/// <summary>
			/// 현금주문금액
			/// </summary>
			public const string MnyOrdAmt = "MnyOrdAmt";
			/// <summary>
			/// 대용주문금액
			/// </summary>
			public const string SubstOrdAmt = "SubstOrdAmt";
			/// <summary>
			/// 재사용주문금액
			/// </summary>
			public const string RuseOrdAmt = "RuseOrdAmt";
			/// <summary>
			/// 계좌명
			/// </summary>
			public const string AcntNm = "AcntNm";
			/// <summary>
			/// 종목명
			/// </summary>
			public const string IsuNm = "IsuNm";
		}

		public static string[] AllFields = new string[]
		{
			F.RecCnt,
			F.OrdNo,
			F.OrdTime,
			F.OrdMktCode,
			F.OrdPtnCode,
			F.ShtnIsuNo,
			F.MgempNo,
			F.OrdAmt,
			F.SpareOrdNo,
			F.CvrgSeqno,
			F.RsvOrdNo,
			F.SpotOrdQty,
			F.RuseOrdQty,
			F.MnyOrdAmt,
			F.SubstOrdAmt,
			F.RuseOrdAmt,
			F.AcntNm,
			F.IsuNm,
		};


		public override Dictionary<string, XAQueryFieldInfo> GetFieldsInfo()
		{
			Dictionary<string, XAQueryFieldInfo> dict = new Dictionary<string, XAQueryFieldInfo>();
			dict["RecCnt"] = new XAQueryFieldInfo("long", RecCnt, RecCnt.ToString("d5"), "레코드갯수", (decimal)5);
			dict["OrdNo"] = new XAQueryFieldInfo("long", OrdNo, OrdNo.ToString("d10"), "주문번호", (decimal)10);
			dict["OrdTime"] = new XAQueryFieldInfo("char", OrdTime, OrdTime, "주문시각", (decimal)9);
			dict["OrdMktCode"] = new XAQueryFieldInfo("char", OrdMktCode, OrdMktCode, "주문시장코드", (decimal)2);
			dict["OrdPtnCode"] = new XAQueryFieldInfo("char", OrdPtnCode, OrdPtnCode, "주문유형코드", (decimal)2);
			dict["ShtnIsuNo"] = new XAQueryFieldInfo("char", ShtnIsuNo, ShtnIsuNo, "단축종목번호", (decimal)9);
			dict["MgempNo"] = new XAQueryFieldInfo("char", MgempNo, MgempNo, "관리사원번호", (decimal)9);
			dict["OrdAmt"] = new XAQueryFieldInfo("long", OrdAmt, OrdAmt.ToString("d16"), "주문금액", (decimal)16);
			dict["SpareOrdNo"] = new XAQueryFieldInfo("long", SpareOrdNo, SpareOrdNo.ToString("d10"), "예비주문번호", (decimal)10);
			dict["CvrgSeqno"] = new XAQueryFieldInfo("long", CvrgSeqno, CvrgSeqno.ToString("d10"), "반대매매일련번호", (decimal)10);
			dict["RsvOrdNo"] = new XAQueryFieldInfo("long", RsvOrdNo, RsvOrdNo.ToString("d10"), "예약주문번호", (decimal)10);
			dict["SpotOrdQty"] = new XAQueryFieldInfo("long", SpotOrdQty, SpotOrdQty.ToString("d16"), "실물주문수량", (decimal)16);
			dict["RuseOrdQty"] = new XAQueryFieldInfo("long", RuseOrdQty, RuseOrdQty.ToString("d16"), "재사용주문수량", (decimal)16);
			dict["MnyOrdAmt"] = new XAQueryFieldInfo("long", MnyOrdAmt, MnyOrdAmt.ToString("d16"), "현금주문금액", (decimal)16);
			dict["SubstOrdAmt"] = new XAQueryFieldInfo("long", SubstOrdAmt, SubstOrdAmt.ToString("d16"), "대용주문금액", (decimal)16);
			dict["RuseOrdAmt"] = new XAQueryFieldInfo("long", RuseOrdAmt, RuseOrdAmt.ToString("d16"), "재사용주문금액", (decimal)16);
			dict["AcntNm"] = new XAQueryFieldInfo("char", AcntNm, AcntNm, "계좌명", (decimal)40);
			dict["IsuNm"] = new XAQueryFieldInfo("char", IsuNm, IsuNm, "종목명", (decimal)40);

			return dict;
		}

		public override void SetFieldValue(string fieldName, XAQueryFieldInfo fieldInfo)
		{
			switch (fieldName)
			{
				case "RecCnt":
					this.RecCnt = fieldInfo.FieldValue.ParseLong("RecCnt");
				break;

				case "OrdNo":
					this.OrdNo = fieldInfo.FieldValue.ParseLong("OrdNo");
				break;

				case "OrdTime":
					this.OrdTime = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdMktCode":
					this.OrdMktCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdPtnCode":
					this.OrdPtnCode = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "ShtnIsuNo":
					this.ShtnIsuNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "MgempNo":
					this.MgempNo = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "OrdAmt":
					this.OrdAmt = fieldInfo.FieldValue.ParseLong("OrdAmt");
				break;

				case "SpareOrdNo":
					this.SpareOrdNo = fieldInfo.FieldValue.ParseLong("SpareOrdNo");
				break;

				case "CvrgSeqno":
					this.CvrgSeqno = fieldInfo.FieldValue.ParseLong("CvrgSeqno");
				break;

				case "RsvOrdNo":
					this.RsvOrdNo = fieldInfo.FieldValue.ParseLong("RsvOrdNo");
				break;

				case "SpotOrdQty":
					this.SpotOrdQty = fieldInfo.FieldValue.ParseLong("SpotOrdQty");
				break;

				case "RuseOrdQty":
					this.RuseOrdQty = fieldInfo.FieldValue.ParseLong("RuseOrdQty");
				break;

				case "MnyOrdAmt":
					this.MnyOrdAmt = fieldInfo.FieldValue.ParseLong("MnyOrdAmt");
				break;

				case "SubstOrdAmt":
					this.SubstOrdAmt = fieldInfo.FieldValue.ParseLong("SubstOrdAmt");
				break;

				case "RuseOrdAmt":
					this.RuseOrdAmt = fieldInfo.FieldValue.ParseLong("RuseOrdAmt");
				break;

				case "AcntNm":
					this.AcntNm = fieldInfo.FieldValue.TrimEnd('?');
				break;

				case "IsuNm":
					this.IsuNm = fieldInfo.FieldValue.TrimEnd('?');
				break;


			}
		}

		public static XQCSPAT00600OutBlock2 FromQuery(XQCSPAT00600 query)
		{
			XQCSPAT00600OutBlock2 block = new XQCSPAT00600OutBlock2();
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
				block.RecCnt = query.GetFieldData(block.GetBlockName(), "RecCnt", 0).ParseLong("RecCnt"); // long 5
				block.OrdNo = query.GetFieldData(block.GetBlockName(), "OrdNo", 0).ParseLong("OrdNo"); // long 10
				block.OrdTime = query.GetFieldData(block.GetBlockName(), "OrdTime", 0).TrimEnd('?'); // char 9
				block.OrdMktCode = query.GetFieldData(block.GetBlockName(), "OrdMktCode", 0).TrimEnd('?'); // char 2
				block.OrdPtnCode = query.GetFieldData(block.GetBlockName(), "OrdPtnCode", 0).TrimEnd('?'); // char 2
				block.ShtnIsuNo = query.GetFieldData(block.GetBlockName(), "ShtnIsuNo", 0).TrimEnd('?'); // char 9
				block.MgempNo = query.GetFieldData(block.GetBlockName(), "MgempNo", 0).TrimEnd('?'); // char 9
				block.OrdAmt = query.GetFieldData(block.GetBlockName(), "OrdAmt", 0).ParseLong("OrdAmt"); // long 16
				block.SpareOrdNo = query.GetFieldData(block.GetBlockName(), "SpareOrdNo", 0).ParseLong("SpareOrdNo"); // long 10
				block.CvrgSeqno = query.GetFieldData(block.GetBlockName(), "CvrgSeqno", 0).ParseLong("CvrgSeqno"); // long 10
				block.RsvOrdNo = query.GetFieldData(block.GetBlockName(), "RsvOrdNo", 0).ParseLong("RsvOrdNo"); // long 10
				block.SpotOrdQty = query.GetFieldData(block.GetBlockName(), "SpotOrdQty", 0).ParseLong("SpotOrdQty"); // long 16
				block.RuseOrdQty = query.GetFieldData(block.GetBlockName(), "RuseOrdQty", 0).ParseLong("RuseOrdQty"); // long 16
				block.MnyOrdAmt = query.GetFieldData(block.GetBlockName(), "MnyOrdAmt", 0).ParseLong("MnyOrdAmt"); // long 16
				block.SubstOrdAmt = query.GetFieldData(block.GetBlockName(), "SubstOrdAmt", 0).ParseLong("SubstOrdAmt"); // long 16
				block.RuseOrdAmt = query.GetFieldData(block.GetBlockName(), "RuseOrdAmt", 0).ParseLong("RuseOrdAmt"); // long 16
				block.AcntNm = query.GetFieldData(block.GetBlockName(), "AcntNm", 0).TrimEnd('?'); // char 40
				block.IsuNm = query.GetFieldData(block.GetBlockName(), "IsuNm", 0).TrimEnd('?'); // char 40

			} catch (InvalidDataFormatException e) {
				block.IsValidData = false;
				block.InvalidReason = $"FieldName == {e.DataFieldName}, FieldData == \"{e.DataValue}\"";
			}
			return block;

		}

		public bool VerifyData()
		{
			if (RecCnt.ToString().Length > 5) return false; // long 5
			if (OrdNo.ToString().Length > 10) return false; // long 10
			if (OrdTime.Length > 9) return false; // char 9
			if (OrdMktCode.Length > 2) return false; // char 2
			if (OrdPtnCode.Length > 2) return false; // char 2
			if (ShtnIsuNo.Length > 9) return false; // char 9
			if (MgempNo.Length > 9) return false; // char 9
			if (OrdAmt.ToString().Length > 16) return false; // long 16
			if (SpareOrdNo.ToString().Length > 10) return false; // long 10
			if (CvrgSeqno.ToString().Length > 10) return false; // long 10
			if (RsvOrdNo.ToString().Length > 10) return false; // long 10
			if (SpotOrdQty.ToString().Length > 16) return false; // long 16
			if (RuseOrdQty.ToString().Length > 16) return false; // long 16
			if (MnyOrdAmt.ToString().Length > 16) return false; // long 16
			if (SubstOrdAmt.ToString().Length > 16) return false; // long 16
			if (RuseOrdAmt.ToString().Length > 16) return false; // long 16
			if (AcntNm.Length > 40) return false; // char 40
			if (IsuNm.Length > 40) return false; // char 40

			return true;
		}
	}

	public partial class XQCSPAT00600 : XingQuery
	{
		/// <summary>
		/// CSPAT00600
		/// </summary>
		static readonly string _typeName = "CSPAT00600";
		/// <summary>
		/// 현물주문
		/// </summary>
		static readonly string _typeDesc = "현물주문";
		/// <summary>
		/// CSPAT00600
		/// </summary>
		static readonly string _service = "CSPAT00600";
		/// <summary>
		/// B
		/// </summary>
		static readonly string _headType = "B";
		/// <summary>
		/// 김기종
		/// </summary>
		static readonly string _creator = "김기종";
		/// <summary>
		/// 2011/12/07 09:23:39
		/// </summary>
		static readonly string _createdDate = "2011/12/07 09:23:39";
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _attr = false;
		/// <summary>
		/// false
		/// </summary>
		static readonly bool _block = false;
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _encrypt = true;
		/// <summary>
		/// true
		/// </summary>
		static readonly bool _signature = true;

		/// <summary>
		/// CSPAT00600
		/// </summary>
		public string TypeName => _typeName;
		/// <summary>
		/// 현물주문
		/// </summary>
		public string TypeDesc => _typeDesc;
		/// <summary>
		/// CSPAT00600
		/// </summary>
		public string Service => _service;
		/// <summary>
		/// B
		/// </summary>
		public string HeadType => _headType;
		/// <summary>
		/// 김기종
		/// </summary>
		public string Creator => _creator;
		/// <summary>
		/// 2011/12/07 09:23:39
		/// </summary>
		public string CreatedDate => _createdDate;
		/// <summary>
		/// false
		/// </summary>
		public bool Attr => _attr;
		/// <summary>
		/// false
		/// </summary>
		public bool Block => _block;
		/// <summary>
		/// true
		/// </summary>
		public bool Encrypt => _encrypt;
		/// <summary>
		/// true
		/// </summary>
		public bool Signature => _signature;

		public XQCSPAT00600() : base("CSPAT00600") { }


		public bool SetFields(XQCSPAT00600InBlock1 block)
		{
			if (block.VerifyData() == false)
			{
				return false; // throw new ApplicationException("Failed to verify: " + block.BlockName);
			}

			_xaQuery.SetFieldData(block.GetBlockName(), "AcntNo", 0, block.AcntNo); // char 20
			_xaQuery.SetFieldData(block.GetBlockName(), "InptPwd", 0, block.InptPwd); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "IsuNo", 0, block.IsuNo); // char 12
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdQty", 0, block.OrdQty.ToString("d16")); // long 16
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdPrc", 0, block.OrdPrc.ToString("0000000000000.00")); // double 13.2
			_xaQuery.SetFieldData(block.GetBlockName(), "BnsTpCode", 0, block.BnsTpCode.ToString()); // char 1
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdprcPtnCode", 0, block.OrdprcPtnCode); // char 2
			_xaQuery.SetFieldData(block.GetBlockName(), "MgntrnCode", 0, block.MgntrnCode); // char 3
			_xaQuery.SetFieldData(block.GetBlockName(), "LoanDt", 0, block.LoanDt); // char 8
			_xaQuery.SetFieldData(block.GetBlockName(), "OrdCndiTpCode", 0, block.OrdCndiTpCode.ToString()); // char 1

			return true;
		}

		public XQCSPAT00600OutBlock1 GetBlock1()
		{
			XQCSPAT00600OutBlock1 instance = XQCSPAT00600OutBlock1.FromQuery(this);
			return instance;

		}

		public XQCSPAT00600OutBlock2 GetBlock2()
		{
			XQCSPAT00600OutBlock2 instance = XQCSPAT00600OutBlock2.FromQuery(this);
			return instance;

		}


	}

}
