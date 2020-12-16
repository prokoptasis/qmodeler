using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using ODS_Exporter;

namespace Q_Modeler
{
	/// <summary>
	/// FLOManager에 대한 요약 설명입니다.
	/// </summary>
	public class FLOMgr
	{
		public FLOMgr()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
			Flolist = new FLOList();
			this.LastCalType = FLOObj.CALTYPE.REP_QTY;
		}

		#region local variables
		public	GudCon Gudcon;
		public	GudSrt Gudsrt;
		public	GudPnt Gudpnt;
		public	static FLOList flolist;
		private FLOObj.CALTYPE lastcaltype;
		#endregion

		#region local variables accessor
		public FLOList Flolist
		{
			get { return flolist; }
			set { flolist = value;}
		}

		public FLOObj.CALTYPE LastCalType
		{
			get { return lastcaltype; }
			set { lastcaltype = value; }
		}
		#endregion

		#region add obj
		public bool AddFLOObj(DrawArea drawArea, FLOObj o)
		{
			if(o != null)
				if(o.Objname != null)
				{
					Flolist.UnselectAll();
					Flolist.Add(o);
					o.Selected = true;
					return true;
				}
				else
					return false;
			else
				return false;
		}

		public FLOObj AddFLOCon(DrawArea drawArea)
		{
			FLOObj c = this.Gudcon.GetConObj(this);
			this.Gudcon.Init();
			return c;
		}

		public void AddFLOStt(DrawArea drawArea)
		{
			FLOObj o = this.Flolist.GetFLOSttObj();
			
			if(o == null)
			{
				o = new FLOStt(drawArea);
				flolist.Add(o);
			}
			else
			{
				o.PopUp(drawArea, new FormFLOStt(drawArea,drawArea.Mgr.Flolist.GetFLOSttObj()));				
			}
		}

		public void FLOSttResize(DrawArea drawArea)
		{
			FLOObj o = this.Flolist.GetFLOSttObj();

			if(o != null)
				o.Drwobj.DRWObjResize(drawArea.ClientRectangle.Right,drawArea.ClientRectangle.Top);
		}
		#endregion

		#region popup
		public void PopUp(DrawArea drawArea, MouseEventArgs e)
		{
			if(Flolist.GetSelectedObjCnt() < 1)
				return;

			if(Flolist.GetSelectedObj().Objtype == FLOObj.OBJTYPE.Stt)
				Flolist.GetSelectedObj().PopUp(drawArea,new FormFLOStt(drawArea,drawArea.Mgr.Flolist.GetFLOSttObj()));

			if(e != null)
			{
				Flolist.UnselectAll();
				Flolist.SelectByPoint(e.X,e.Y);
			}

			if(Flolist.GetSelectedObjCnt() == 1)
			{
				Flolist.GetSelectedObj().PopUp(this,new FormFLO());
				return;
			}

			if(Flolist.GetSelectedObjTypeMatch())
				return;
			
			PopUpMulti(drawArea, e);

			return;
		}

		private void PopUpMulti(DrawArea drawArea, MouseEventArgs e)
		{
			FormFLO f = new FormFLO();

			switch(this.Flolist.GetSelectedObjType())
			{
				case FLOObj.OBJTYPE.Buf:
					f = new FormFLOBuf(99);
					break;
				case FLOObj.OBJTYPE.Cal:
					f = new FormFLOCal(99);
					break;
				case FLOObj.OBJTYPE.Res:
					f = new FormFLORes(99);
					break;
				case FLOObj.OBJTYPE.Dmd:
					f = new FormFLODmd(99);
					break;
				case FLOObj.OBJTYPE.Ope:
					f = new FormFLOOpe(99);
					break;
				case FLOObj.OBJTYPE.B2O:
					f = new FormFLOB2O(99,new ArrayList());
					break;
				case FLOObj.OBJTYPE.O2B:
					f = new FormFLOO2B(99);
					break;
				case FLOObj.OBJTYPE.R2O:
					f = new FormFLOR2O(99,new ArrayList());
					break;
				default:
					return;
			}

			if(this.Flolist.GetSelectedObj().Objtype == FLOObj.OBJTYPE.Buf)
				foreach(FLOObj o in Flolist.GetSelectedObjList())
					foreach(FLOObj c in o.Rtlist)
						if(c.Objtype == FLOObj.OBJTYPE.B2D)
							f.LockedForm(98);

			if(this.Flolist.GetSelectedObj().Objtype == FLOObj.OBJTYPE.Cal)
				if(Flolist.GetSelectedCalObjConned())
					f.LockedForm(98);

			if(this.Flolist.GetSelectedObj().Objtype == FLOObj.OBJTYPE.B2O)
				if(Flolist.GetSelectedBomObjTypeMatch())
					f.LockedForm(98);

			if(this.Flolist.GetSelectedObj().Objtype == FLOObj.OBJTYPE.O2B)
				if(Flolist.GetSelectedOpeObjTypeMatch() == FLOObj.OPETYPE.AltRouting)
					f.LockedForm(97);
				else if(Flolist.GetSelectedOpeObjTypeMatch() == FLOObj.OPETYPE.CoByProd)
					f.LockedForm(98);
				else
					f.LockedForm(99);

			foreach(FLOObj o in Flolist.GetSelectedObjList())
			{
				f.SetAttrMulti(o);
			}
					
			DialogResult r = f.ShowDialog();
            
			if(r == DialogResult.OK)
			{
				foreach(FLOObj o in Flolist.GetSelectedObjList())
				{
					if(!Flolist.CheckObjNameUnique(f.GetObjName(o),o))
					{
						f.GetAttrMulti(o);
						o.Oldname = o.Objname;
						o.Objname = f.GetObjName(o);
						o.Disname = f.GetDisName(o);
						o.UpdateCon();
					}
				}
			}
		}
		#endregion

		#region draw
		public void Draw(Graphics g)
		{
			if(this.Flolist.Count > 0)
				Flolist.Draw(g);				
	
			this.Gudcon.Draw(g);
			this.Gudsrt.Draw(g);
			//this.Gudstt.Draw(g);
		}
		#endregion

		public void FLOExport(ODSExporter exp)
		{
			if(!exp.SetFullPath())
				return;

			exp.ODSExport(this.Flolist.GetInstanceMaster());
			exp.ODSExport(this.Flolist.GetEnterpriseMaster());
			exp.ODSExport(this.Flolist.GetSupplyChainMaster());
			exp.ODSExport(this.Flolist.GetOrganizationMaster());
			exp.ODSExport(this.Flolist.GetSiteMaster());
			exp.ODSExport(this.Flolist.GetOrganizationSiteRelation());			
			exp.ODSExport(this.Flolist.GetItemMaster());
			exp.ODSExport(this.Flolist.GetItemSiteMaster());
			exp.ODSExport(this.Flolist.GetItemGroupMaster());
			exp.ODSExport(this.Flolist.GetItemGroupDetail());
			exp.ODSExport(this.Flolist.GetItemSiteRepPolicy());
			exp.ODSExport(this.Flolist.GetItemSiteRepParameters());
			exp.ODSExport(this.Flolist.GetItemSiteIPParameters());
			exp.ODSExport(this.Flolist.GetRoutingHeader());
			exp.ODSExport(this.Flolist.GetRoutingOperation());
			exp.ODSExport(this.Flolist.GetBomHeader());
			exp.ODSExport(this.Flolist.GetBomComponents());
			exp.ODSExport(this.Flolist.GetBomComponentsAlternate());
			exp.ODSExport(this.Flolist.GetBillOfCobyProducts());
			exp.ODSExport(this.Flolist.GetItemBomRouting());
			exp.ODSExport(this.Flolist.GetResourceMaster());
			exp.ODSExport(this.Flolist.GetWorkcenterMaster());
			exp.ODSExport(this.Flolist.GetWorkcenterDetail());
			exp.ODSExport(this.Flolist.GetCalendarMaster());
			exp.ODSExport(this.Flolist.GetCalendarDetail());
			exp.ODSExport(this.Flolist.GetCalendarBasedAttributes());
			exp.ODSExport(this.Flolist.GetCalendarPatternDetail());
			exp.ODSExport(this.Flolist.GetResourceCalendar());
			exp.ODSExport(this.Flolist.GetOperationResource());
			exp.ODSExport(this.Flolist.GetOperationResourcesAdditional());
			exp.ODSExport(this.Flolist.GetOperationResourcesAlternate());
			exp.ODSExport(this.Flolist.GetOperationCalendar());
			exp.ODSExport(this.Flolist.GetItemGroupCalendar());
			exp.ODSExport(this.Flolist.GetSalesOrderMaster());
			exp.ODSExport(this.Flolist.GetSalesOrderLine());
			exp.ODSExport(this.Flolist.GetBucketMaster());
			exp.ODSExport(this.Flolist.GetBucketPattern());
			exp.ODSExport(this.Flolist.GetPlanMaster());
			exp.ODSExport(this.Flolist.GetPlanParameters());
			exp.ODSExport(this.Flolist.GetLpLayer());
			exp.ODSExport(this.Flolist.GetObjectiveParameters());
		}
	}
}
