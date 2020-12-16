using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Globalization;
using System.Diagnostics;
using System.Reflection;

namespace Q_Modeler
{
	/// <summary>
	/// flolist에 대한 요약 설명입니다.
	/// </summary>
	[Serializable]
	public class FLOList : ISerializable
	{
		public FLOList()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
			flolist = new ArrayList();
		}

		#region flolist local variables
		private ArrayList flolist;
		#endregion

		#region public basic method (access for flolist)
		public void Add(FLOObj o)
		{
			flolist.Insert(0, o);
		}

		public void Delete(FLOObj o)
		{
			flolist.Remove(o);
		}

		public void Clear()
		{
			flolist.Clear();
		}

		public int Count
		{
			get
			{
				return flolist.Count;
			}
		}

		public FLOObj this [int index]
		{
			get
			{
				if ( index < 0  ||  index >= flolist.Count )
					return null;

				return ((FLOObj)flolist[index]);
			}
		}

		public bool MoveSelectionToFront()
		{
			int n;
			int i;
			ArrayList tempList;

			tempList = new ArrayList();
			n = flolist.Count;

			// Read source list in reverse order, add every selected item
			// to temporary list and remove it from source list
			for ( i = n - 1; i >= 0; i-- )
			{
				if ( ((FLOObj)flolist[i]).Selected )
				{
					tempList.Add(flolist[i]);
					flolist.RemoveAt(i);
				}
			}

			// Read temporary list in direct order and insert every item
			// to the beginning of the source list
			n = tempList.Count;

			for ( i = 0; i < n; i++ )
			{
				flolist.Insert(0, tempList[i]);
			}

			return ( n > 0 );
		}

		/// <summary>
		/// Move selected items to back (end of the list)
		/// </summary>
		/// <returns>
		/// true if at least one object is moved
		/// </returns>
		public bool MoveSelectionToBack()
		{
			int n;
			int i;
			ArrayList tempList;

			tempList = new ArrayList();
			n = flolist.Count;

			// Read source list in reverse order, add every selected item
			// to temporary list and remove it from source list
			for ( i = n - 1; i >= 0; i-- )
			{
				if ( ((FLOObj)flolist[i]).Selected )
				{
					tempList.Add(flolist[i]);
					flolist.RemoveAt(i);
				}
			}

			// Read temporary list in reverse order and add every item
			// to the end of the source list
			n = tempList.Count;

			for ( i = n - 1; i >= 0; i-- )
			{
				flolist.Add(tempList[i]);
			}

			return ( n > 0 );
		}
		#endregion

		#region get floobj sequence for default naming
		public int GetObjSeq(FLOObj.OBJTYPE objtype)
		{
			int r = 0;

			int max = 0;
			int min = 0;

			ArrayList seqlist = new ArrayList();
			ArrayList dellist = new ArrayList();

			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == objtype)
				{
					seqlist.Add(o.Seq);
				
					if(o.Seq > max)
						max = o.Seq;
				}
			}

			if(seqlist.Count != max)
			{
				for(int i = 0; i < max; i++)
				{
					if(!seqlist.Contains(i+1))
						dellist.Add(i+1);
				}

				min = (int)dellist[0];

				for(int i = 0; i < dellist.Count; i ++)
				{
					if((int)dellist[i] < min)
						min = (int)dellist[i];
				}

				r = min;
			}
			else
			{
				r = max + 1;
			}
			
			return r;
		}
		#endregion

		#region draw
		public void Draw(Graphics g)
		{
			int n = flolist.Count;

			FLOObj o;

			for (int i = n - 1; i >= 0; i-- )
			{
				o = (FLOObj)flolist[i];
				o.Drwobj.Draw(g);
			}
		}
		#endregion

		#region delete
		public void Delete()
		{
			foreach(FLOObj o in this.flolist)
			{
				if(o.Objtype.ToString().Substring(1,1) == "2")
				{
					if(o.Ltlist != null)
						if(o.LTlist(0).Selected || o.RTlist(0).Selected)
							o.Selected = true;

					if(o.Uplist != null)
						if(o.UPlist(0).Selected || o.DNlist(0).Selected)
							o.Selected = true;
				}
			}

			DeleteAltConBySel();
			DeleteConLstBySel();
			DeleteSelectedObj();
		}

		private void DeleteAltConBySel()
		{
			foreach(FLOObj o in this.flolist)
			{
				if(o.Objtype.ToString().Substring(1,1) == "2" && o.Selected)
				{
					switch(o.Objtype)
					{
						case FLOObj.OBJTYPE.B2O:
						{
							foreach(FLOObj c in o.RTlist(0).Ltlist)
							{
								if(c.Objtype == FLOObj.OBJTYPE.B2O)
									if(c.B2O_constype == FLOObj.BOMTYPE.Alternate)
										if(c.B2O_altbuf == o.LTlist(0).Objname)
											c.Selected = true;
							}
						} break;
						case FLOObj.OBJTYPE.O2B:
						{
							foreach(FLOObj c in o.LTlist(0).Rtlist)
							{
								if(c.Objtype == FLOObj.OBJTYPE.O2B)
									if(c.O2B_prodtype == FLOObj.OPETYPE.CoByProd)
										c.Selected = true;
							}

							foreach(FLOObj c in o.RTlist(0).Ltlist)
							{
								if(c.Objtype == FLOObj.OBJTYPE.O2B && o.O2B_prodtype == FLOObj.OPETYPE.Normal)
									if(c.O2B_prodtype == FLOObj.OPETYPE.AltRouting)
									{
										c.Selected = true;
										foreach(FLOObj cc in c.LTlist(0).Rtlist)
										{
											if(cc.O2B_prodtype == FLOObj.OPETYPE.CoByProd)
												cc.Selected = true;
										}
									}
							}

						} break;
						case FLOObj.OBJTYPE.O2C:
						{
							if(o.DNlist(0).Cal_caltype == FLOObj.CALTYPE.EFFICIENCY)
								DelecteEffResByCal(o);
						} break;
						case FLOObj.OBJTYPE.R2O:
						{
							this.DeleteAltResByRes(o);
							this.DeleteEffCalByRes(o);
						} break;
					}
				}
			}
		}

		private void DeleteEffCalByRes(FLOObj o)
		{
			foreach(FLOObj c in o.DNlist(0).Dnlist)
			{
				if(c.DNlist(0).Cal_caltype == FLOObj.CALTYPE.EFFICIENCY)
					if(c.O2C_effresource == o.UPlist(0).Objname)
					{
						c.Selected = true;
						DelecteEffResByCal(c);
					}
			}
		}	

		private void DeleteAltResByRes(FLOObj o)
		{
			foreach(FLOObj c in o.DNlist(0).Uplist)
			{
				if(c.R2O_restype == FLOObj.RESTYPE.Alternate)
					if(c.R2O_altresource == o.UPlist(0).Objname)
					{
						c.Selected = true;
						DeleteEffCalByRes(c);
					}
			}
		}

		private void DelecteEffResByCal(FLOObj o)
		{
			foreach(FLOObj c in o.UPlist(0).Uplist)
			{
				if(c.UPlist(0).Objname == o.O2C_effresource)
				{
					c.Selected = true;
					DeleteAltResByRes(c);
				}
			}
		}

		private void DeleteConLstBySel()
		{
			foreach(FLOObj o in this.GetSelectedObjList())
			{
				if(o.Objtype.ToString().Substring(1,1) == "2")
				{
					if(o.Uplist != null)
					{
						if(o.UPlist(0).Dnlist.Contains(o))
							o.UPlist(0).Dnlist.Remove(o);

						if(o.DNlist(0).Uplist.Contains(o))
							o.DNlist(0).Uplist.Remove(o);
					}

					if(o.Ltlist != null)
					{
						if(o.LTlist(0).Rtlist.Contains(o))
							o.LTlist(0).Rtlist.Remove(o);

						if(o.RTlist(0).Ltlist.Contains(o))
							o.RTlist(0).Ltlist.Remove(o);
					}
				}
			}
		}

		public void DeleteSelectedObj()
		{
			foreach(FLOObj o in this.GetSelectedObjList())
			{
				if(flolist.Contains(o))
					flolist.Remove(o);
			}

		}
		#endregion

		#region select
		public void SelectAll()
		{
			foreach(FLOObj o in this.flolist)
			{
				o.Selected = true;
			}
		}

		public void SelectByPoint(int x, int y)
		{
			foreach(FLOObj o in this.flolist)
			{
				if( o.Drwobj.HitTest(new Point(x, y)) )
					o.Selected = true;
			}
		}

		public void SelectByRect(Rectangle rect)
		{
			foreach(FLOObj o in this.flolist)
			{
				if(o.Drwobj.IntersectsWith(rect))
				{
					o.Selected = true;
				}
			}
		}

		public void UnselectAll()
		{
			foreach(FLOObj o in this.flolist)
			{
				o.Selected = false;
			}
		}
		#endregion

		#region get obj
		public FLOObj GetObjByName(string objname)
		{
			foreach(FLOObj o in this.flolist)
			{
				if(o.Objname == objname)
					return o;
			}

			return null;
		}

		public FLOObj GetObjByPoint(Point point)
		{
			foreach(FLOObj o in this.flolist)
			{
				if(o.Drwobj.HitTest(point))
					return o;
			}

			return null;
		}

		public FLOObj GetObjByConPoint(Point point)
		{
			foreach(FLOObj o in this.flolist)
			{
				if(o.Objtype.ToString().Substring(1,1) != "2")
					if(o.Drwobj.HitTest(point))
						return o;
			}

			return null;
		}

		public int GetSelectedObjCnt()
		{
			int n = 0;

			foreach(FLOObj o in this.flolist)
			{
				if(o.Selected)
					n++;
			}

			return n;
		}

		public FLOObj GetSelectedObj()
		{
			foreach(FLOObj o in this.flolist)
			{
				if(o.Selected)
					return o;
			}

			return null;
		}

		public ArrayList GetSelectedObjList()
		{
			ArrayList list = new ArrayList();
			
			foreach(FLOObj o in this.flolist)
			{
				if(o.Selected)
					list.Add(o);
			}

			return list;
		}

		public FLOObj.OBJTYPE GetSelectedObjType()
		{
			foreach(FLOObj o in this.flolist)
			{
				if(o.Selected)
					return o.Objtype;
			}

			return FLOObj.OBJTYPE.NULL;
		}

		public bool GetSelectedObjTypeMatch()
		{
			FLOObj.OBJTYPE objtype = this.GetSelectedObjType();
			
			foreach(FLOObj o in this.GetSelectedObjList())
			{
				if(o.Objtype != objtype)
					return true;
			}

			return false;
		}

		public bool GetSelectedCalObjTypeMatch()
		{
			FLOObj.CALTYPE caltype = this.GetSelectedObj().Cal_caltype;

			foreach(FLOObj o in this.GetSelectedObjList())
			{
				if(o.Cal_caltype != caltype)
					return false;
			}

			return true;
		}

		public bool GetSelectedBomObjTypeMatch()
		{
			FLOObj.BOMTYPE type = this.GetSelectedObj().B2O_constype;

			foreach(FLOObj o in this.GetSelectedObjList())
			{
				if(o.B2O_constype != type)
					return false;
			}

			return true;
		}

		public FLOObj.OPETYPE GetSelectedOpeObjTypeMatch()
		{
			FLOObj.OPETYPE type = this.GetSelectedObj().O2B_prodtype;

			foreach(FLOObj o in this.GetSelectedObjList())
			{
				if(o.O2B_prodtype != type)
					return FLOObj.OPETYPE.NULL;
			}

			return type;
		}


		public bool GetSelectedCalObjConned()
		{
			foreach(FLOObj o in this.GetSelectedObjList())
			{
				if(o.Uplist.Count > 0 || o.Dnlist.Count > 0)
					return false;
			}

			return true;
		}

		public FLOObj GetFLOSttObj()
		{
			foreach(FLOObj o in this.flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Stt)
					return o;
			}

			return null;
		}

		public ArrayList GetFLODmdPriorityList()
		{
			ArrayList list = new ArrayList();
			foreach(FLOObj o in this.flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Dmd)
					if(!list.Contains(o.Dmd_orderpriority))
						list.Add(o.Dmd_orderpriority);
			}

			return list;
		}

		public ArrayList GetFLOBufStageList()
		{
			ArrayList list = new ArrayList();
			foreach(FLOObj o in this.flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Buf)
					if(!list.Contains(o.Buf_stage))
						list.Add(o.Buf_stage);
			}

			return list;
		}
		#endregion

		#region move
		public void GetSelectedObjMove(int dx, int dy)
		{
			foreach(FLOObj o in this.flolist)
			{
				if(o.Selected && o.Objtype.ToString().Substring(1,1) != "2")
					o.Drwobj.Move(dx, dy);
			}

			foreach(FLOObj o in this.flolist)
			{
				if(o.Objtype.ToString().Substring(1,1) == "2")
				{
					if(o.Ltlist != null)
						if(o.LTlist(0).Selected || o.RTlist(0).Selected)
							o.Drwobj.SetConPoint(o.LTlist(0),o.RTlist(0));

					if(o.Uplist != null)
						if(o.UPlist(0).Selected || o.DNlist(0).Selected)
							o.Drwobj.SetConPoint(o.UPlist(0),o.DNlist(0));
				}
			}
		}

		public void GetAllObjMove(int dx, int dy)
		{
			foreach(FLOObj o in this.flolist)
			{
				o.Drwobj.Move(dx, dy);
			}
		}
		#endregion

		#region checkobjnameunique
		public bool CheckObjNameUnique(string objname, FLOObj org)
		{
			if(this.Count < 1)
				return false;

			if(objname == null)
				return true;

			if(objname == "")
				return true;

			if(objname == "@")
				return true;

			if(objname == "O_@")
				return true;

			if(objname == "O_@_0")
				return true;

			if(objname == "R_@")
				return true;

			foreach(FLOObj o in this.flolist)
			{
				if(o.Objname == objname && !o.Equals(org))
					return true;
			}

			return false;
		}
		#endregion

		#region entry variables
		private const string entryCount = "Count";
		private const string entryType	= "Type";	
		#endregion

		#region savetostream & loadtostream
		protected FLOList(SerializationInfo info, StreamingContext context)
		{
			flolist = new ArrayList();

			int n = info.GetInt32(entryCount);
			string typeName;
			object floObj;

			for ( int i = 0; i < n; i++ )
			{
				typeName = info.GetString( String.Format(CultureInfo.InvariantCulture, "{0}{1}", entryType,i));

				floObj = Assembly.GetExecutingAssembly().CreateInstance(typeName);

				((FLOObj)floObj).LoadFromStream(info,i);
        
				flolist.Add(floObj);
			}

			foreach(FLOObj o in flolist)
			{
				o.RestoreArrayList(this);
			}
		}

		[SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter=true)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue(entryCount, flolist.Count);

			int i = 0;

			foreach ( FLOObj o in flolist )
			{
				info.AddValue( String.Format(CultureInfo.InvariantCulture, "{0}{1}", entryType, i), o.GetType().FullName);
				o.SaveToStream(info, i);
				i++;
			}
		}
		#endregion

		#region export to flatfile
		public ArrayList GetInstanceMaster()
		{
			// InstanceMaster : #INSTANCEID	BITPOSITION
			ArrayList result = new ArrayList();

			result.Add("InstanceMaster");
			result.Add(2);
			result.Add("#INSTANCEID");
			result.Add("BITPOSITION");

			result.Add(this.GetFLOSttObj().Stt_instanceid);
			result.Add(this.GetFLOSttObj().Stt_bitposition.ToString());

			return result;
		}

		public ArrayList GetEnterpriseMaster()
		{
			// EnterpriseMaster : #ENTERPRISE	ENGINE_ID
			ArrayList result = new ArrayList();

			result.Add("EnterpriseMaster");
			result.Add(2);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");

			result.Add(this.GetFLOSttObj().Stt_enterprise);
			result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());

			return result;
		}

		public ArrayList GetSupplyChainMaster()
		{
			// SupplyChainMaster : #ENTERPRISE	ENGINE_ID	SUPPLYCHAINID
			ArrayList result = new ArrayList();

			result.Add("SupplyChainMaster");
			result.Add(3);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("SUPPLYCHAINID");

			result.Add(this.GetFLOSttObj().Stt_enterprise);
			result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
			result.Add(this.GetFLOSttObj().Stt_supplychainid);

			return result;
		}

		public ArrayList GetOrganizationMaster()
		{
			// SupplyChainMaster : #ENTERPRISE	ENGINE_ID	ORGANIZATIONID
			ArrayList result = new ArrayList();

			result.Add("OrganizationMaster");
			result.Add(4);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("ORGANIZATIONID");
			result.Add("ORGANIZATIONTYPE");

			result.Add(this.GetFLOSttObj().Stt_enterprise);
			result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
			result.Add(this.GetFLOSttObj().Stt_organizationid);
			result.Add("Manufacturing");

			return result;
		}

		public ArrayList GetSiteMaster()
		{
			// SiteMaster : #ENTERPRISE	ENGINE_ID	SITEID
			ArrayList result = new ArrayList();

			result.Add("SiteMaster");
			result.Add(3);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("SITEID");
			
			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Buf)
				{
					if(!result.Contains(o.Buf_site))
					{
						result.Add(this.GetFLOSttObj().Stt_enterprise);
						result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
						result.Add(o.Buf_site);
					}
				}
				else if(o.Objtype == FLOObj.OBJTYPE.Ope)
				{
					if(!result.Contains(o.Ope_operationsite))
					{
						result.Add(this.GetFLOSttObj().Stt_enterprise);
						result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
						result.Add(o.Ope_operationsite);
					}
				}
				else if(o.Objtype == FLOObj.OBJTYPE.Res)
				{
					if(!result.Contains(o.Res_resourcesite))
					{
						result.Add(this.GetFLOSttObj().Stt_enterprise);
						result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
						result.Add(o.Res_resourcesite);
					}
				}
			}

			return result;
		}

		public ArrayList GetOrganizationSiteRelation()
		{
			// OrganizationSiteRelation : #ENTERPRISE	ENGINE_ID	ORGANIZATIONID	SITEID
			ArrayList result = new ArrayList();

			result.Add("OrganizationSiteRelation");
			result.Add(4);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("ORGANIZATIONID");
			result.Add("SITEID");
			
			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Buf)
				{
					if(!result.Contains(o.Buf_site))
					{
						result.Add(this.GetFLOSttObj().Stt_enterprise);
						result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
						result.Add(this.GetFLOSttObj().Stt_organizationid);
						result.Add(o.Buf_site);
					}
				}
				else if(o.Objtype == FLOObj.OBJTYPE.Ope)
				{
					if(!result.Contains(o.Ope_operationsite))
					{
						result.Add(this.GetFLOSttObj().Stt_enterprise);
						result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
						result.Add(this.GetFLOSttObj().Stt_organizationid);
						result.Add(o.Ope_operationsite);
					}
				}
				else if(o.Objtype == FLOObj.OBJTYPE.Res)
				{
					if(!result.Contains(o.Res_resourcesite))
					{
						result.Add(this.GetFLOSttObj().Stt_enterprise);
						result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
						result.Add(this.GetFLOSttObj().Stt_organizationid);
						result.Add(o.Res_resourcesite);
					}
				}
			}

			return result;
		}

		public ArrayList GetItemMaster()
		{
			// ItemMaster : #ENTERPRISE	ENGINE_ID ITEM
			ArrayList result = new ArrayList();

			result.Add("ItemMaster");
			result.Add(3);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("ITEM");
			
			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Buf)
				{
					result.Add(this.GetFLOSttObj().Stt_enterprise);
					result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
					result.Add(o.Buf_item);
				}
			}

			return result;
		}

		public ArrayList GetItemSiteMaster()
		{
			// ItemSiteMaster : #ENTERPRISE,ENGINE_ID,SITEID,ITEM,SELLABLE,ISRESPONSEBUFFER,ISPRODUCTIONPLANBUFFER, STAGE		
			ArrayList result = new ArrayList();

			result.Add("ItemSiteMaster");
			result.Add(8);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("SITEID");
			result.Add("ITEM");
			result.Add("SELLABLE");
			result.Add("ISRESPONSEBUFFER");
			result.Add("ISPRODUCTIONPLANBUFFER");
			result.Add("STAGE");
			
			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Buf)
				{
					result.Add(this.GetFLOSttObj().Stt_enterprise);
					result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
					result.Add(o.Buf_site);
					result.Add(o.Buf_item);
					result.Add(o.Buf_sellable.ToString());
					result.Add(o.Buf_isresponsebuffer.ToString());
					result.Add(o.Buf_isproductionplanbuffer.ToString());
					result.Add(o.Buf_stage);
				}
			}

			return result;
		}

		public ArrayList GetItemGroupMaster()
		{
			// ItemSiteMaster : #ENTERPRISE	ENGINE_ID	ITEMGROUP	GROUPTYPE
			ArrayList result = new ArrayList();

			result.Add("ItemGroupMaster");
			result.Add(4);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("ITEMGROUP");
			result.Add("GROUPTYPE");
			
			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Buf)
				{
					result.Add(this.GetFLOSttObj().Stt_enterprise);
					result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
					result.Add(o.Buf_item + "@" + o.Buf_site);
					result.Add("INV_STYLE");
				}
			}

			return result;
		}

		public ArrayList GetItemGroupDetail()
		{
			// ItemGroupDetail : #ENTERPRISE ENGINE_ID ORGANIZATIONID ITEMGROUP ITEM SITEID
			ArrayList result = new ArrayList();

			result.Add("ItemGroupDetail");
			result.Add(6);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("ORGANIZATIONID");
			result.Add("ITEMGROUP");
			result.Add("ITEM");
			result.Add("SITEID");
			
			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Buf)
				{
					result.Add(this.GetFLOSttObj().Stt_enterprise);
					result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
					result.Add("");
					result.Add(o.Buf_item + "@" + o.Buf_site);
					result.Add(o.Buf_item);
					result.Add(o.Buf_site);
				}
			}

			return result;
		}

		public ArrayList GetItemSiteRepPolicy()
		{
			// ItemGroupDetail : #ENTERPRISE ENGINE_ID ORGANIZATIONID ITEMGROUP REPPOLICY
			ArrayList result = new ArrayList();

			result.Add("ItemSiteRepPolicy");
			result.Add(5);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("ORGANIZATIONID");
			result.Add("ITEMGROUP");
			result.Add("REPPOLICY");
			
			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Buf)
				{
					result.Add(this.GetFLOSttObj().Stt_enterprise);
					result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
					result.Add(this.GetFLOSttObj().Stt_organizationid);
					result.Add(o.Buf_item + "@" + o.Buf_site);
					
					if(o.Dnlist.Count > 0)
					{
						result.Add("SUPPLY_CALENDAR");
					}
					else if(o.Ltlist.Count < 1 && o.Dnlist.Count < 1)
					{
						result.Add("INFINITE");
					}
					else
					{
						result.Add("PRODUCING_FLOW_CALENDAR_FILTER_AND_RANK");
					}
				}
			}

			return result;
		}

		public ArrayList GetItemSiteRepParameters()
		{
			// ItemGroupDetail : #ENTERPRISE ENGINE_ID ORGANIZATIONID ITEMGROUP SITEID ITEM MINONHAND MAXONHAND DAYSOFCOVERAGE MAXDAYSOFCOVERAGE
			ArrayList result = new ArrayList();

			result.Add("ItemSiteRepParameters");
			result.Add(8);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("ORGANIZATIONID");
			result.Add("ITEMGROUP");
			result.Add("MINONHAND");
			result.Add("MAXONHAND");
			result.Add("DAYSOFCOVERAGE");
			result.Add("MAXDAYSOFCOVERAGE");
			
			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Buf)
				{
					result.Add(this.GetFLOSttObj().Stt_enterprise);
					result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
					result.Add(this.GetFLOSttObj().Stt_organizationid);
					result.Add(o.Buf_item + "@" + o.Buf_site);
					result.Add("");
					result.Add("");
					result.Add("");
					result.Add("");
				}
			}

			return result;
		}

		public ArrayList GetItemSiteIPParameters()
		{
			// ItemGroupDetail : #ENTERPRISE ENGINE_ID ORGANIZATIONID ITEMGROUP INVCARRYPOLICY
			ArrayList result = new ArrayList();

			result.Add("ItemSiteIPParameters");
			result.Add(5);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("ORGANIZATIONID");
			result.Add("ITEMGROUP");
			result.Add("INVCARRYPOLICY");
			
			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Buf)
				{
					result.Add(this.GetFLOSttObj().Stt_enterprise);
					result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
					result.Add(this.GetFLOSttObj().Stt_organizationid);
					result.Add(o.Buf_item + "@" + o.Buf_site);
					result.Add("");					
				}
			}

			return result;
		}

		public ArrayList GetRoutingHeader()
		{
			// RoutingHeader : #ENTERPRISE	ENGINE_ID	SITEID	ROUTINGID

			ArrayList result = new ArrayList();

			result.Add("RoutingHeader");
			result.Add(4);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("SITEID");
			result.Add("ROUTINGID");
			
			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Ope)
				{
					if(!result.Contains(o.Ope_routingpre + o.Ope_routing + "@" + o.Ope_operationsite))
					{
						result.Add(this.GetFLOSttObj().Stt_enterprise);
						result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
						result.Add(o.Ope_operationsite);
						result.Add(o.Ope_routingpre + o.Ope_routing + "@" + o.Ope_operationsite);
					}
				}
			}

			return result;
		}

		public ArrayList GetRoutingOperation()
		{
			// RoutingHeader : #ENTERPRISE	ENGINE_ID	
			// SITEID	ROUTINGID	OPERATION	OPERATIONSEQ	
			// OPTYPE	STAGINGPOLICY	AVGFIXEDRUNTIME	TIMEUOM RELEASEFENCE RELEASEFENCEUOM
 

			ArrayList result = new ArrayList();

			result.Add("RoutingOperation");
			result.Add(13);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("SITEID");
			result.Add("ROUTINGID");
			result.Add("OPERATION");
			result.Add("OPERATIONSEQ");
			result.Add("OPTYPE");
			result.Add("STAGINGPOLICY");
			result.Add("AVGFIXEDRUNTIME");
			result.Add("TIMEUOM");
			result.Add("VARQTYREJECTED");
			result.Add("RELEASEFENCE");
			result.Add("RELEASEFENCEUOM");
			
			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Ope)
				{
					result.Add(this.GetFLOSttObj().Stt_enterprise);
					result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
					result.Add(o.Ope_operationsite);
					result.Add(o.Ope_routingpre + o.Ope_routing + "@" + o.Ope_operationsite);
					result.Add(o.Ope_operationpre + o.Ope_operation + "@" + o.Ope_operationsite + "_" + o.Ope_operationseq.ToString());
					result.Add(o.Ope_operationseq.ToString());
					result.Add("Manufacturing");
					result.Add("MINIMAL");
					result.Add(o.Ope_runtime.ToString());
					result.Add("day");
					result.Add("");
					result.Add(o.Ope_releasefence.ToString());
					result.Add("day");
				}
			}

			return result;
		}

		public ArrayList GetBomHeader()
		{
			// RoutingHeader : #ENTERPRISE	ENGINE_ID	SITEID	BOMID	QTYPRODUCED
			ArrayList result = new ArrayList();

			result.Add("BomHeader");
			result.Add(5);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("SITEID");
			result.Add("BOMID");
			result.Add("QTYPRODUCED");
			
			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Ope)
				{
					// 솔로인 놈들은 제외...
					if(o.Rtlist.Count > 0 && o.Ltlist.Count > 0)
					{
						result.Add(this.GetFLOSttObj().Stt_enterprise);
						result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
						result.Add(o.Ope_operationsite);
						result.Add(FLOObj.BMPRE + o.Ope_operation + "@" + o.Ope_operationsite + "_" + o.Ope_operationseq.ToString());

						foreach(FLOObj c in o.Rtlist)
						{
							if(c.Objtype == FLOObj.OBJTYPE.O2O)
							{
								result.Add(c.O2O_prodqty.ToString());
								break;
							}

							if(c.Objtype == FLOObj.OBJTYPE.O2B)
								if(c.O2B_prodtype != FLOObj.OPETYPE.CoByProd)
								{
									result.Add(c.O2B_prodqty.ToString());
									break;
								}
						}
					}					
				}
			}

			return result;
		}

		public ArrayList GetBomComponents()
		{
			// RoutingHeader : #ENTERPRISE	ENGINE_ID	SITEID	BOMID	ITEM	QTYPER	COMPONENTSITEID
			ArrayList result = new ArrayList();

			result.Add("BomComponents");
			result.Add(8);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("SITEID");
			result.Add("BOMID");
			result.Add("ITEM");
			result.Add("QTYPER");
			result.Add("COMPONENTSITEID");
			result.Add("YIELD");
			
			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Ope)
				{					
					foreach(FLOObj c in o.Ltlist)
					{
						// constype이 정상인 놈들만 ...
						if(c.B2O_constype == FLOObj.BOMTYPE.Normal)
						{
							result.Add(this.GetFLOSttObj().Stt_enterprise);
							result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
							result.Add(o.Ope_operationsite);
							result.Add(FLOObj.BMPRE + o.Ope_operation + "@" + o.Ope_operationsite + "_" + o.Ope_operationseq.ToString());
							result.Add(c.LTlist(0).Buf_item);
							result.Add(c.B2O_cosqty.ToString());
							result.Add(c.LTlist(0).Buf_site);
							result.Add("");
						}
					}					
				}
			}

			return result;
		}

		public ArrayList GetBomComponentsAlternate()
		{
			// RoutingHeader : ALTERNATEITEM	ALTCOMPONENTSITEID	QTYPER	PRIORITY
			ArrayList result = new ArrayList();

			result.Add("BomComponentsAlternate");
			result.Add(9);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("BOMID");
			result.Add("SITEID");
			result.Add("ITEM");
			result.Add("ALTCOMPONENTSITEID");			
			result.Add("ALTERNATEITEM");
			result.Add("QTYPER");
			result.Add("PRIORITY");
			
			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Ope)
				{					
					foreach(FLOObj c in o.Ltlist)
					{
						// constype이 alt인 놈들만 ...
						if(c.B2O_constype == FLOObj.BOMTYPE.Alternate)
						{
							result.Add(this.GetFLOSttObj().Stt_enterprise);
							result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
							result.Add(FLOObj.BMPRE + o.Ope_operation + "@" + o.Ope_operationsite + "_" + o.Ope_operationseq.ToString());

							FLOObj oo = this.GetObjByName(c.B2O_altbuf);
							result.Add(oo.Buf_site);
							result.Add(oo.Buf_item);

							result.Add(c.LTlist(0).Buf_site);
							result.Add(c.LTlist(0).Buf_item);
							result.Add(c.B2O_cosqty);
							result.Add(c.B2O_altpriority);
						}
					}					
				}
			}

			return result;
		}

		public ArrayList GetBillOfCobyProducts()
		{
			// RoutingHeader : #ENTERPRISE	ENGINE_ID	SITEID	BOMID	ROUTINGID	ITEM	
			// QTYPRODUCED	OPERATIONSEQ	COBYPRODUCTS
			// CobySiteid ????
			ArrayList result = new ArrayList();

			result.Add("BillOfCobyProducts");
			result.Add(11);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("SITEID");
			result.Add("ROUTINGID");
			result.Add("BOMID");
			result.Add("OPERATIONSEQ");
			result.Add("ITEM");			
			result.Add("COBYPRODUCTSITEID");			
			result.Add("QTYPRODUCED");
			result.Add("QTYPERCENT");
			result.Add("COBYPRODUCTS");
			
			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Ope)
				{					
					foreach(FLOObj c in o.Rtlist)
					{
						// prodtype이 coby인 놈들만 ...
						if(c.O2B_prodtype == FLOObj.OPETYPE.CoByProd)
						{
							result.Add(this.GetFLOSttObj().Stt_enterprise);
							result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
							result.Add(o.Ope_operationsite);
							result.Add(o.Ope_routingpre + o.Ope_routing + "@" + o.Ope_operationsite);
							result.Add(FLOObj.BMPRE + o.Ope_operation + "@" + o.Ope_operationsite + "_" + o.Ope_operationseq.ToString());
							result.Add(o.Ope_operationseq.ToString());
							result.Add(c.RTlist(0).Buf_item);
							result.Add(c.RTlist(0).Buf_site);
							result.Add(c.O2B_cobyprodqty.ToString());
							result.Add(c.O2B_cobyprodrate.ToString());
							result.Add(c.O2B_cobyprod.ToString());
						}
					}					
				}
			}

			return result;
		}

		public ArrayList GetItemBomRouting()
		{
			// #ENTERPRISE	ENGINE_ID	SITEID	ROUTINGID	BOMID	ITEM	EFFSTARTDATE	
			ArrayList result = new ArrayList();

			result.Add("ItemBomRouting");
			result.Add(13);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("SITEID");
			result.Add("ROUTINGID");
			result.Add("BOMID");
			result.Add("ITEM");			
			result.Add("PRIORITY");
			result.Add("RTNGUSAGEPERCENT");
			result.Add("LOTSIZEINCREMENT");			
			result.Add("MINLOTSIZE");
			result.Add("MAXLOTSIZE");
			result.Add("YIELD");
			result.Add("YIELDCALENDAR");

			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Ope)
				{					
					foreach(FLOObj c in o.Rtlist)
					{
						if(c.O2B_prodtype == FLOObj.OPETYPE.Normal || c.O2B_prodtype == FLOObj.OPETYPE.AltRouting)
						{
							result.Add(this.GetFLOSttObj().Stt_enterprise);
							result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
							result.Add(o.Ope_operationsite);
							result.Add(o.Ope_routingpre + o.Ope_routing + "@" + o.Ope_operationsite);
							result.Add(FLOObj.BMPRE + o.Ope_operation + "@" + o.Ope_operationsite + "_" + o.Ope_operationseq.ToString());
							result.Add(c.RTlist(0).Buf_item);
							result.Add(c.O2B_altpriority);
							result.Add(c.O2B_altproportion);
							result.Add("");
							result.Add("");
							result.Add("");
							result.Add("");
							result.Add("");
						}
					}					
				}
			}

			return result;
		}

		public ArrayList GetResourceMaster()
		{
			// #ENTERPRISE	ENGINE_ID	SITEID	RESOURCENAME	RESOURCETYPE
			ArrayList result = new ArrayList();

			result.Add("ResourceMaster");
			result.Add(5);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("SITEID");
			result.Add("RESOURCENAME");
			result.Add("RESOURCETYPE");

			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Res)
				{					
					result.Add(this.GetFLOSttObj().Stt_enterprise);
					result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
					result.Add(o.Res_resourcesite);
					result.Add(o.Res_resourcepre + o.Res_resource + "@" + o.Res_resourcesite);
					result.Add("MACHINE");
				}
			}

			return result;
		}

		public ArrayList GetWorkcenterMaster()
		{
			// #ENTERPRISE	ENGINE_ID	SITEID	WORKCENTERNAME	CATEGORY
			ArrayList result = new ArrayList();

			result.Add("WorkcenterMaster");
			result.Add(5);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("SITEID");
			result.Add("WORKCENTERNAME");
			result.Add("CATEGORY");

			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Res)
				{	
					// resource site 중복 제거
					if(!result.Contains(o.Res_resourcesite))
					{
						result.Add(this.GetFLOSttObj().Stt_enterprise);
						result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
						result.Add(o.Res_resourcesite);
						result.Add(this.GetFLOSttObj().Stt_workcenter);
						result.Add("Manufacturing");
					}
				}
			}

			return result;
		}

		public ArrayList GetWorkcenterDetail()
		{
			// #ENTERPRISE	ENGINE_ID	SITEID	RESOURCENAME	WORKCENTERNAME	
			// LOADPOLICY	IS_RESPONSE_BUFFER	IS_PRODUCTION_PLAN_BUFFER
			ArrayList result = new ArrayList();

			result.Add("WorkcenterDetail");
			result.Add(8);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("SITEID");
			result.Add("RESOURCENAME");
			result.Add("WORKCENTERNAME");
			result.Add("LOADPOLICY");
			result.Add("IS_RESPONSE_BUFFER");
			result.Add("IS_PRODUCTION_PLAN_BUFFER");

			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Res)
				{					
					result.Add(this.GetFLOSttObj().Stt_enterprise);
					result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
					result.Add(o.Res_resourcesite);
					result.Add(o.Res_resourcepre + o.Res_resource + "@" + o.Res_resourcesite);
					result.Add(this.GetFLOSttObj().Stt_workcenter);
					result.Add("FLOW_LIMIT_CALENDAR");
					result.Add("1");
					result.Add("1");
				}
			}

			return result;
		}

		public ArrayList GetCalendarMaster()
		{
			// #ENTERPRISE	ENGINE_ID	SITEID	RESOURCENAME	WORKCENTERNAME	
			// LOADPOLICY	IS_RESPONSE_BUFFER	IS_PRODUCTION_PLAN_BUFFER
			ArrayList result = new ArrayList();

			result.Add("CalendarMaster");
			result.Add(3);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("CALENDARNAME");

			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Cal)
				{					
					result.Add(this.GetFLOSttObj().Stt_enterprise);
					result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
					result.Add(o.Cal_calendarpre + o.Cal_calendar);
				}
			}

			return result;
		}

		public ArrayList GetCalendarDetail()
		{
			//#ENTERPRISE	ENGINE_ID	CALENDARNAME	PATTERNSEQ	
			// PATTERNNAME	EFFSTARTDATE	EFFENDDATE	SHIFTNUMBER	PRIORITY
			ArrayList result = new ArrayList();

			result.Add("CalendarDetail");
			result.Add(9);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("CALENDARNAME");
			result.Add("PATTERNSEQ");
			result.Add("PATTERNNAME");
			result.Add("EFFSTARTDATE");
			result.Add("EFFENDDATE");
			result.Add("SHIFTNUMBER");
			result.Add("PRIORITY");

			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Cal)
				{
					foreach(FLOCal.Cal_Detail detail in o.Cal_details)
					{
						result.Add(this.GetFLOSttObj().Stt_enterprise);
						result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
						result.Add(o.Cal_calendarpre + o.Cal_calendar);
						result.Add(detail.cal_detaildx.ToString());
						result.Add(o.Cal_pattern.ToString());
						result.Add(ConDate(detail.cal_effstart));
						result.Add(ConDate(detail.cal_effend));
						result.Add("1");
						result.Add("100");
					}
				}
			}

			return result;
		}

		public ArrayList GetCalendarBasedAttributes()
		{
			//#ENTERPRISE	ENGINE_ID	CALENDARNAME	SHIFTNUMBER	
			// PATTERNSEQ	ATTRIBUTE	VALUE
			ArrayList result = new ArrayList();

			result.Add("CalendarBasedAttributes");
			result.Add(7);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("CALENDARNAME");
			result.Add("PATTERNSEQ");
			result.Add("SHIFTNUMBER");
			result.Add("ATTRIBUTE");
			result.Add("VALUE");

			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Cal)
				{
					foreach(FLOCal.Cal_Detail detail in o.Cal_details)
					{
						result.Add(this.GetFLOSttObj().Stt_enterprise);
						result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
						result.Add(o.Cal_calendarpre + o.Cal_calendar);
						result.Add(detail.cal_detaildx.ToString());
						result.Add("1");
						result.Add(o.Cal_caltype.ToString());
						result.Add(detail.cal_qtyper.ToString());
					}
				}
			}

			return result;
		}

		public ArrayList GetCalendarPatternDetail()
		{
			//#ENTERPRISE	ENGINE_ID	CALENDARNAME	SHIFTNUMBER	
			//PATTERNSEQ	ATTRIBUTE	ATTRIBUTEVALUE
			//SEC_HDD_EP	4	RC_R_AS-112-35@PG10	1	20061002	days	MO
			ArrayList result = new ArrayList();

			result.Add("CalendarPatternDetail");
			result.Add(7);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("CALENDARNAME");
			result.Add("PATTERNSEQ");
			result.Add("SHIFTNUMBER");
			result.Add("ATTRIBUTE");
			result.Add("ATTRIBUTEVALUE");

			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.Cal)
				{
					foreach(FLOCal.Cal_Detail detail in o.Cal_details)
					{
						result.Add(this.GetFLOSttObj().Stt_enterprise);
						result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
						result.Add(o.Cal_calendarpre + o.Cal_calendar);
						result.Add(detail.cal_detaildx.ToString());
						result.Add("1");

						if(o.Cal_pattern == FLOObj.CPTTYPE.EVERY_N_DAYS)
						{
							result.Add("nth");
							result.Add(o.Cal_numofday.ToString());
						}
						else if(o.Cal_pattern == FLOObj.CPTTYPE.EVERY_N_DAYS)
						{
							result.Add("days");
							result.Add(o.Cal_dayofweek);
						}
						else
						{
							result.Add("day");
							result.Add(o.Cal_numofday.ToString());
						}
					}
				}
			}

			return result;
		}

		public ArrayList GetResourceCalendar()
		{
			//#ENTERPRISE	ENGINE_ID	SITEID	WORKCENTERNAME	
			// RESOURCENAME	CALENDARNAME	CALENDARTYPE
			ArrayList result = new ArrayList();

			result.Add("ResourceCalendar");
			result.Add(7);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("SITEID");
			result.Add("RESOURCENAME");
			result.Add("WORKCENTERNAME");
			result.Add("CALENDARNAME");
			result.Add("CALENDARTYPE");

			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.C2R)
				{
					result.Add(this.GetFLOSttObj().Stt_enterprise);
					result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
					result.Add(o.DNlist(0).Res_resourcesite);
					result.Add(o.DNlist(0).Res_resourcepre + o.DNlist(0).Res_resource + "@" + o.DNlist(0).Res_resourcesite);
					result.Add(this.GetFLOSttObj().Stt_workcenter);
					result.Add(o.UPlist(0).Cal_calendarpre + o.UPlist(0).Cal_calendar);
					result.Add("CAPACITY");
				}
			}

			return result;
		}

		public ArrayList GetOperationResource()
		{
			//#ENTERPRISE	ENGINE_ID	SITEID	WORKCENTERNAME	RESOURCENAME	
			// ROUTINGID	OPERATIONSEQ	RUNTIMEPER	PRODRATE
			ArrayList result = new ArrayList();

			result.Add("OperationResource");
			result.Add(9);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("SITEID");
			result.Add("RESOURCENAME");
			result.Add("WORKCENTERNAME");
			result.Add("ROUTINGID");
			result.Add("OPERATIONSEQ");
			result.Add("RUNTIMEPER");
			result.Add("PRODRATE");

			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.R2O)
				{
					if(o.R2O_restype == FLOObj.RESTYPE.Normal)
					{
						result.Add(this.GetFLOSttObj().Stt_enterprise);
						result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
						result.Add(o.UPlist(0).Res_resourcesite);
						result.Add(o.UPlist(0).Res_resourcepre + o.UPlist(0).Res_resource + "@" + o.UPlist(0).Res_resourcesite);
						result.Add(this.GetFLOSttObj().Stt_workcenter);
						result.Add(o.DNlist(0).Ope_routingpre + o.DNlist(0).Ope_routing + "@" + o.DNlist(0).Ope_operationsite);
						result.Add(o.DNlist(0).Ope_operationseq.ToString());
						result.Add(o.R2O_qtyper.ToString());
						result.Add("");
					}
				}
			}

			return result;
		}

		public ArrayList GetOperationResourcesAdditional()
		{
			//#ENTERPRISE	ENGINE_ID	SITEID	ROUTINGID	OPERATIONSEQ	
			//ADDWORKCENTERNAME	ADDRESOURCENAME	RESOURCENAME	WORKCENTERNAME
			ArrayList result = new ArrayList();

			result.Add("OperationResourcesAdditional");
			result.Add(11);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("SITEID");
			result.Add("ADDRESOURCENAME");
			result.Add("ADDWORKCENTERNAME");
			result.Add("ROUTINGID");
			result.Add("OPERATIONSEQ");
			result.Add("RESOURCENAME");
			result.Add("WORKCENTERNAME");
			result.Add("RUNTIMEPER");
			result.Add("PRODRATE");

			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.R2O)
				{
					if(o.R2O_restype == FLOObj.RESTYPE.Simultaneous)
					{
						result.Add(this.GetFLOSttObj().Stt_enterprise);
						result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
						result.Add(o.UPlist(0).Res_resourcesite);
						result.Add(o.UPlist(0).Res_resourcepre + o.UPlist(0).Res_resource + "@" + o.UPlist(0).Res_resourcesite);
						result.Add(this.GetFLOSttObj().Stt_workcenter);
						result.Add(o.DNlist(0).Ope_routingpre + o.DNlist(0).Ope_routing + "@" + o.DNlist(0).Ope_operationsite);
						result.Add(o.DNlist(0).Ope_operationseq.ToString());

						foreach(FLOObj oo in o.DNlist(0).Uplist)
						{
							if(oo.R2O_restype == FLOObj.RESTYPE.Normal)
							{
								result.Add(oo.UPlist(0).Res_resourcepre + oo.UPlist(0).Res_resource + "@" + oo.UPlist(0).Res_resourcesite);
								result.Add(this.GetFLOSttObj().Stt_workcenter);
							}
						}

						result.Add(o.R2O_qtyper.ToString());
						result.Add("");
					}
				}
			}

			return result;
		}

		public ArrayList GetOperationResourcesAlternate()
		{
			//#ENTERPRISE	ENGINE_ID	SITEID	ROUTINGID	RESOURCENAME	
			//ALTRESOURCENAME	 RUNTIMEPER	 PRIORITY	 OPERATIONSEQ	OPERATION	WORKCENTERNAME	
			//ALTWORKCENTERNAME
			ArrayList result = new ArrayList();

			result.Add("OperationResourcesAlternate");
			result.Add(12);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("SITEID");
			result.Add("ALTRESOURCENAME");
			result.Add("ALTWORKCENTERNAME");
			result.Add("PRIORITY");
			result.Add("RUNTIMEPER");
			result.Add("ROUTINGID");
			result.Add("OPERATION");
			result.Add("OPERATIONSEQ");
			result.Add("RESOURCENAME");
			result.Add("WORKCENTERNAME");


			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.R2O)
				{
					if(o.R2O_restype == FLOObj.RESTYPE.Alternate)
					{
						result.Add(this.GetFLOSttObj().Stt_enterprise);
						result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
						result.Add(o.UPlist(0).Res_resourcesite);
						result.Add(o.UPlist(0).Res_resourcepre + o.UPlist(0).Res_resource + "@" + o.UPlist(0).Res_resourcesite);
						result.Add(this.GetFLOSttObj().Stt_workcenter);
						result.Add(o.R2O_altpriority.ToString());
						result.Add(o.R2O_qtyper.ToString());
						result.Add(o.DNlist(0).Ope_routingpre + o.DNlist(0).Ope_routing + "@" + o.DNlist(0).Ope_operationsite);
						result.Add(o.DNlist(0).Ope_operationpre + o.DNlist(0).Ope_operation + "@" + o.DNlist(0).Ope_operationsite + "_" + o.DNlist(0).Ope_operationseq.ToString());						
						result.Add(o.DNlist(0).Ope_operationseq.ToString());

						result.Add(this.GetObjByName(o.R2O_altresource).Res_resourcepre + this.GetObjByName(o.R2O_altresource).Res_resource + "@" + this.GetObjByName(o.R2O_altresource).Res_resourcesite);
						result.Add(this.GetFLOSttObj().Stt_workcenter);
					}
				}
			}
			return result;
		}			

		public ArrayList GetOperationCalendar()
		{
			//#ENTERPRISE	ENGINE_ID	SITEID	ROUTINGID	CALENDARNAME	
			//CALENDARTYPE	OPERATION	RESOURCENAME	WORKCENTERNAME
			ArrayList result = new ArrayList();

			result.Add("OperationCalendar");
			result.Add(9);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("SITEID");
			result.Add("ROUTINGID");
			result.Add("OPERATION");
			result.Add("CALENDARNAME");
			result.Add("CALENDARTYPE");
			result.Add("RESOURCENAME");
			result.Add("WORKCENTERNAME");

			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.O2C)
				{
					result.Add(this.GetFLOSttObj().Stt_enterprise);
					result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
					result.Add(o.UPlist(0).Ope_operationsite);
					result.Add(o.UPlist(0).Ope_routingpre + o.UPlist(0).Ope_routing + "@" + o.UPlist(0).Ope_operationsite);
					result.Add(o.UPlist(0).Ope_operationpre + o.UPlist(0).Ope_operation + "@" + o.UPlist(0).Ope_operationsite + "_" + o.UPlist(0).Ope_operationseq.ToString());											
					result.Add(o.DNlist(0).Cal_calendarpre + o.DNlist(0).Cal_calendar);
					result.Add(o.DNlist(0).Cal_caltype.ToString());
					
					if(o.DNlist(0).Cal_caltype == FLOObj.CALTYPE.EFFICIENCY)
					{
						result.Add(this.GetObjByName(o.O2C_effresource).Res_resourcepre + this.GetObjByName(o.O2C_effresource).Res_resource + "@" + this.GetObjByName(o.O2C_effresource).Res_resourcesite);
						result.Add(this.GetFLOSttObj().Stt_workcenter);
					}
					else
					{
						result.Add("");
						result.Add("");
					}
				}
			}
			return result;
		}

		public ArrayList GetItemGroupCalendar()
		{
			//#ENTERPRISE	ENGINE_ID	ORGANIZATIONID	
			// ITEMGROUP	CALENDARNAME	SITEID	ITEM	CALENDARTYPE

			ArrayList result = new ArrayList();

			result.Add("ItemGroupCalendar");
			result.Add(8);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("ORGANIZATIONID");
			result.Add("ITEMGROUP");
			result.Add("SITEID");
			result.Add("ITEM");
			result.Add("CALENDARNAME");
			result.Add("CALENDARTYPE");

			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.B2C)
				{
					result.Add(this.GetFLOSttObj().Stt_enterprise);
					result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
					result.Add(this.GetFLOSttObj().Stt_organizationid);
					result.Add(o.UPlist(0).Buf_item + "@" + o.UPlist(0).Buf_site);
					result.Add("");
					result.Add("");
					result.Add(o.DNlist(0).Cal_calendarpre + o.DNlist(0).Cal_calendar);
					result.Add(o.DNlist(0).Cal_caltype.ToString());
				}
			}
			return result;
		}

		public ArrayList GetSalesOrderMaster()
		{
			//#ENTERPRISE	ENGINE_ID	SITEID	SALESORDERID
			ArrayList result = new ArrayList();

			result.Add("SalesOrderMaster");
			result.Add(4);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("SITEID");
			result.Add("SALESORDERID");

			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.B2D)
				{
					result.Add(this.GetFLOSttObj().Stt_enterprise);
					result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
					result.Add(o.LTlist(0).Buf_site);
					result.Add(o.RTlist(0).Dmd_sorderid);
				}
			}
			return result;
		}

		public ArrayList GetSalesOrderLine()
		{
			//#ENTERPRISE	ENGINE_ID	ORGANIZATIONID	SITEID	SALESORDERID	
			//ITEM	QTYORDERED	SCHEDULEDSHIPDATE	PRIORITY	LATENESSTOLERANCE	
			//TOLERANCEUOM	QTYOPEN	SOLINENUM	DELIVERYGROUP	SALESNAME	
			//SALESLEVEL	REQUESTEDITEM	ORDERMAXQTY	ORDERMINQTY	QTYUOM	
			//REQUESTEDDELIVERYSTARTDATE	REQUESTEDDELIVERYENDDATE	PROMISEDDELIVERYDATE	
			//PROMISEDMATAVAILDATE	PROMISEDSHIPPINGDATE
			ArrayList result = new ArrayList();

			result.Add("SalesOrderLine");
			result.Add(21);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("ORGANIZATIONID");
			result.Add("SITEID");
			result.Add("SALESORDERID");
			result.Add("SOLINENUM");
			result.Add("ITEM");
			result.Add("QTYORDERED");
			result.Add("SCHEDULEDSHIPDATE");
			result.Add("PRIORITY");
			result.Add("LATENESSTOLERANCE");
			result.Add("TOLERANCEUOM");
			result.Add("QTYOPEN");
			result.Add("REQUESTEDITEM");
			result.Add("ORDERMAXQTY");
			result.Add("ORDERMINQTY");
			result.Add("REQUESTEDDELIVERYSTARTDATE");
			result.Add("REQUESTEDDELIVERYENDDATE");
			result.Add("PROMISEDDELIVERYDATE");
			result.Add("PROMISEDMATAVAILDATE");
			result.Add("PROMISEDSHIPPINGDATE");

			foreach(FLOObj o in flolist)
			{
				if(o.Objtype == FLOObj.OBJTYPE.B2D)
				{
					result.Add(this.GetFLOSttObj().Stt_enterprise);
					result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
					result.Add(this.GetFLOSttObj().Stt_organizationid);
					result.Add(o.LTlist(0).Buf_site);
					result.Add(o.RTlist(0).Dmd_sorderid);
					result.Add("1");
					result.Add(o.LTlist(0).Buf_item);
					result.Add(o.RTlist(0).Dmd_orderqty.ToString());
					result.Add(ConDate(o.RTlist(0).Dmd_ordereddate));
					result.Add(o.RTlist(0).Dmd_orderpriority.ToString());
					result.Add(o.RTlist(0).Dmd_latenesstolerance.ToString());
					result.Add("day");
					result.Add(o.RTlist(0).Dmd_orderqty.ToString());
					result.Add(o.LTlist(0).Buf_item);
					result.Add("");
					result.Add("");
					result.Add("");
					result.Add("");
					result.Add("");
					result.Add("");
					result.Add("");
				}
			}
			return result;
		}

		public ArrayList GetBucketMaster()
		{
			// #ENTERPRISE	ENGINE_ID	BUCKETNAME	BOUNDARYID	FIRSTDAYOFWEEK	EFFSTARTDATE
			// SEC_HDD_EP	4	LP_HORIZON	Planning_Cal	1	10/01/2006
			ArrayList result = new ArrayList();

			result.Add("BucketMaster");
			result.Add(6);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("BUCKETNAME");
			result.Add("BOUNDARYID");
			result.Add("FIRSTDAYOFWEEK");
			result.Add("EFFSTARTDATE");

			result.Add(this.GetFLOSttObj().Stt_enterprise);
			result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
			result.Add(this.GetFLOSttObj().Stt_bucketname);
			result.Add(this.GetFLOSttObj().Stt_boundaryid);
			result.Add(this.GetFLOSttObj().Stt_firstdayofweek.ToString());
			result.Add(ConDate(this.GetFLOSttObj().Stt_effstartdate));

			return result;
		}

		public ArrayList GetBucketPattern()
		{
			// #ENTERPRISE	ENGINE_ID	BUCKETNAME	BOUNDARYID	FIRSTDAYOFWEEK	EFFSTARTDATE
			// SEC_HDD_EP	4	LP_HORIZON	Planning_Cal	1	10/01/2006
			ArrayList result = new ArrayList();

			result.Add("BucketPattern");
			result.Add(7);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("BUCKETNAME");
			result.Add("PATTERNSEQUENCE");
			result.Add("BUCKETSIZE");
			result.Add("BUCKETSIZEUOM");
			result.Add("NUMBEROFBUCKETS");

			result.Add(this.GetFLOSttObj().Stt_enterprise);
			result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
			result.Add(this.GetFLOSttObj().Stt_bucketname);
			result.Add(this.GetFLOSttObj().Stt_patternsequence.ToString());
			result.Add(this.GetFLOSttObj().Stt_bucketsize.ToString());
			result.Add(this.GetFLOSttObj().Stt_bucketsizeuom);
			result.Add(this.GetFLOSttObj().Stt_numberofbuckets.ToString());

			return result;
		}

		public ArrayList GetPlanMaster()
		{
			//#ENTERPRISE	ENGINE_ID	SUPPLYCHAINID	INSTANCEID	
			//PLANID	EFFSTARTDATE	EFFENDDATE	CURRENTDATE	PLANDESC
			ArrayList result = new ArrayList();

			result.Add("PlanMaster");
			result.Add(9);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("SUPPLYCHAINID");
			result.Add("INSTANCEID");
			result.Add("PLANID");
			result.Add("EFFSTARTDATE");
			result.Add("EFFENDDATE");
			result.Add("CURRENTDATE");
			result.Add("PLANDESC");

			result.Add(this.GetFLOSttObj().Stt_enterprise);
			result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
			result.Add(this.GetFLOSttObj().Stt_supplychainid);
			result.Add(this.GetFLOSttObj().Stt_instanceid);
			result.Add(this.GetFLOSttObj().Stt_planid);
			result.Add(ConDate(this.GetFLOSttObj().Stt_planstartdate));
			result.Add(ConDate(this.GetFLOSttObj().Stt_planenddate));
			result.Add(ConDate(this.GetFLOSttObj().Stt_plancurrentdate));
			result.Add("Active");

			return result;
		}

		public ArrayList GetPlanParameters()
		{
			//#ENTERPRISE	ENGINE_ID	PLANID	PARAMETERNAME	PARAMETERVALUE
			ArrayList result = new ArrayList();

			result.Add("PlanParameters");
			result.Add(5);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("PLANID");
			result.Add("PARAMETERNAME");
			result.Add("PARAMETERVALUE");

			result.Add(this.GetFLOSttObj().Stt_enterprise);
			result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
			result.Add(this.GetFLOSttObj().Stt_planid);
			result.Add("keep_or_better");
			result.Add(this.GetFLOSttObj().Stt_keep_or_better.ToString());

			result.Add(this.GetFLOSttObj().Stt_enterprise);
			result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
			result.Add(this.GetFLOSttObj().Stt_planid);
			result.Add("export_unpegged_material");
			result.Add(this.GetFLOSttObj().Stt_export_unpegged_material.ToString());

			result.Add(this.GetFLOSttObj().Stt_enterprise);
			result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
			result.Add(this.GetFLOSttObj().Stt_planid);
			result.Add("export_unpegged_capacity");
			result.Add(this.GetFLOSttObj().Stt_export_unpegged_capacity.ToString());

			result.Add(this.GetFLOSttObj().Stt_enterprise);
			result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
			result.Add(this.GetFLOSttObj().Stt_planid);
			result.Add("export_date_range");
			result.Add(this.GetFLOSttObj().Stt_export_date_range.ToString() + "day");

			result.Add(this.GetFLOSttObj().Stt_enterprise);
			result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
			result.Add(this.GetFLOSttObj().Stt_planid);
			result.Add("export_source_peggings");
			result.Add(this.GetFLOSttObj().Stt_export_source_peggings.ToString());

			result.Add(this.GetFLOSttObj().Stt_enterprise);
			result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
			result.Add(this.GetFLOSttObj().Stt_planid);
			result.Add("mpa_solver");
			result.Add(this.GetFLOSttObj().Stt_mpa_solver);

			result.Add(this.GetFLOSttObj().Stt_enterprise);
			result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());
			result.Add(this.GetFLOSttObj().Stt_planid);
			result.Add("use_transport_capacity");
			result.Add(this.GetFLOSttObj().Stt_use_transport_capacity);

			return result;
		}

		public ArrayList GetLpLayer()
		{
			//#ENTERPRISE	ENGINE_ID	PLANID	PARAMETERNAME	PARAMETERVALUE
			ArrayList result = new ArrayList();

			result.Add("LpLayer");
			result.Add(8);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("LAYERNAME");
			result.Add("LAYERTYPE");
			result.Add("DEMANDPRIORITYSTART");
			result.Add("DEMANDPRIORITYEND");
			result.Add("PRIORITY");
			result.Add("DEMANDBANDS");

			foreach(FLOStt.LPLayer layer in this.GetFLOSttObj().Stt_lplayers)
			{
				result.Add(this.GetFLOSttObj().Stt_enterprise);
				result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());

				result.Add(layer.stt_layername);
				result.Add(layer.stt_layertype);
				result.Add(layer.stt_demandprioritystart.ToString());
				result.Add(layer.stt_demandpriorityend.ToString());
				result.Add(layer.stt_priority.ToString());
				result.Add(layer.stt_demandbands);
			}
			return result;
		}

		public ArrayList GetObjectiveParameters()
		{
			//#ENTERPRISE	ENGINE_ID	OBLEVEL	PRIORITY	ISTIMEWEIGHTED	QUALIFIER	PLANID	LPMETHOD
			ArrayList result = new ArrayList();

			result.Add("OBJECTIVEPARAMETERS");
			result.Add(8);
			result.Add("#ENTERPRISE");
			result.Add("ENGINE_ID");
			result.Add("OBLEVEL");
			result.Add("PRIORITY");
			result.Add("ISTIMEWEIGHTED");
			result.Add("QUALIFIER");
			result.Add("PLANID");
			result.Add("LPMETHOD");

			foreach(FLOStt.OBLevel level in this.GetFLOSttObj().Stt_oblevels)
			{
				result.Add(this.GetFLOSttObj().Stt_enterprise);
				result.Add(this.GetFLOSttObj().Stt_engine_id.ToString());

				result.Add(level.stt_oblevel);
				result.Add(level.stt_priority.ToString());
				result.Add(level.stt_istimeweighted.ToString());
				result.Add(level.stt_qualifier);
				result.Add(this.GetFLOSttObj().Stt_planid);
				result.Add(level.stt_lpmethod);
			}
			return result;
		}

		private string ConDate(string orgdate)
		{
			return orgdate.Substring(5,2) + "/" + orgdate.Substring(8,2) + "/" + orgdate.Substring(0,4);
		}

		#endregion
	}
}
