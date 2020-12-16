using System;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;
using System.Drawing;

namespace Q_Modeler
{
	/// <summary>
	/// FLOSTT에 대한 요약 설명입니다.
	/// </summary>
	public class FLOStt : Q_Modeler.FLOObj
	{
		public FLOStt()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

		#region buf local variables
		/// <summary>
		/// static data
		/// </summary>
		private string	stt_instanceid;
		private int		stt_bitposition;
		private string	stt_enterprise;
		private int		stt_engine_id;		// bitposition^2	
		private string	stt_supplychainid;
		private string	stt_organizationid;
		private string	stt_workcenter;

		/// <summary>
		/// planmaster
		/// </summary>
		private string stt_planid;
		private string stt_planstartdate;	// datetime type
		private string stt_planenddate;		// datetime type
		private string stt_plancurrentdate;	// datetime type

		/// <summary>
		/// bucket master
		/// </summary>
		private string stt_bucketname;
		private string stt_boundaryid;
		private int	   stt_firstdayofweek;
		private string stt_effstartdate;

		/// <summary>
		/// bucket pattern
		/// </summary>
		private int		stt_patternsequence;
		private int		stt_bucketsize;			
		private string	stt_bucketsizeuom;		// day or week		
		private int		stt_numberofbuckets;	// plan horizon / bucketsize*(day/week)

		/// <summary>
		/// plan parameters
		/// </summary>
		private int		stt_keep_or_better;				// 0
		private int		stt_export_unpegged_material;	// 1
		private int		stt_export_unpegged_capacity;	// 1
		private int		stt_export_date_range;			// plan horizon (day)
		private int		stt_export_source_peggings;		// 1
		private string	stt_mpa_solver;					// false
		private int		stt_use_transport_capacity;		// 1

		/// <summary>
		/// lplayer	: create after modeling
		/// </summary>
		[Serializable]
		public struct LPLayer				// create by demand priority
		{
			public string	stt_layername;			// "layer" + seq
			public string	stt_layertype;			// B / S
			public int		stt_demandprioritystart;	// demand priority
			public int		stt_demandpriorityend;		// demand priority
			public int		stt_priority;				// demand priority
			public string	stt_demandbands;			// string input
		}

		/// <summary>
		/// object parameters : creat after modeling
		/// </summary>
		[Serializable]
		public struct OBLevel
		{
			public string	stt_oblevel;		// fixed
			public int		stt_priority;		// sequencial
			public int		stt_istimeweighted;	// 0 or 1
			public string	stt_qualifier;		// Layer, buffer.stage(), none
			public string	stt_lpmethod;		// P
		}

		private ArrayList stt_lplayers;
		private ArrayList stt_oblevels;
		#endregion

		#region buf local variables accessor
		public override string Stt_instanceid
		{
			get { return stt_instanceid; }
			set { stt_instanceid = value; }
		}

		public override string Stt_enterprise
		{
			get { return stt_enterprise; }
			set { stt_enterprise = value; }
		}

		public override string Stt_supplychainid
		{
			get { return stt_supplychainid; }
			set { stt_supplychainid = value; }
		}

		public override string Stt_organizationid
		{
			get { return stt_organizationid; }
			set { stt_organizationid = value; }
		}

		public override string Stt_workcenter
		{
			get { return stt_workcenter; }
			set { stt_workcenter = value; }
		}

		public override string Stt_planid
		{
			get { return stt_planid; }
			set { stt_planid = value; }
		}

		public override string Stt_planstartdate
		{
			get { return stt_planstartdate; }
			set { stt_planstartdate = value; }
		}

		public override string Stt_planenddate
		{
			get { return stt_planenddate; }
			set { stt_planenddate = value; }
		}

		public override string Stt_plancurrentdate
		{
			get { return stt_plancurrentdate; }
			set { stt_plancurrentdate = value; }
		}

		public override string Stt_bucketname
		{
			get { return stt_bucketname; }
			set { stt_bucketname = value; }
		}

		public override string Stt_boundaryid
		{
			get { return stt_boundaryid; }
			set { stt_boundaryid = value; }
		}

		public override string Stt_effstartdate
		{
			get { return stt_effstartdate; }
			set { stt_effstartdate = value; }
		}

		public override string Stt_bucketsizeuom
		{
			get { return stt_bucketsizeuom; }
			set { stt_bucketsizeuom = value; }
		}

		public override string Stt_mpa_solver
		{
			get { return stt_mpa_solver; }
			set { stt_mpa_solver = value; }
		}

		public override int Stt_bitposition
		{
			get { return stt_bitposition; }
			set { stt_bitposition = value; }
		}

		public override int Stt_engine_id
		{
			get { return stt_engine_id; }
			set { stt_engine_id = value; }
		}

		public override int Stt_firstdayofweek
		{
			get { return stt_firstdayofweek; }
			set { stt_firstdayofweek = value; }
		}

		public override int Stt_patternsequence
		{
			get { return stt_use_transport_capacity; }
			set { stt_use_transport_capacity = value; }
		}

		public override int Stt_bucketsize
		{
			get { return stt_bucketsize; }
			set { stt_bucketsize = value; }
		}

		public override int Stt_numberofbuckets
		{
			get { return stt_numberofbuckets; }
			set { stt_numberofbuckets = value; }
		}

		public override int Stt_keep_or_better
		{
			get { return stt_keep_or_better; }
			set { stt_keep_or_better = value; }
		}

		public override int Stt_export_unpegged_material
		{
			get { return stt_export_unpegged_material; }
			set { stt_export_unpegged_material = value; }
		}

		public override int Stt_export_unpegged_capacity
		{
			get { return stt_export_unpegged_capacity; }
			set { stt_export_unpegged_capacity = value; }
		}

		public override int Stt_export_date_range
		{
			get { return stt_export_date_range; }
			set { stt_export_date_range = value; }
		}

		public override int Stt_export_source_peggings
		{
			get { return stt_export_source_peggings; }
			set { stt_export_source_peggings = value; }
		}

		public override int Stt_use_transport_capacity
		{
			get { return stt_use_transport_capacity; }
			set { stt_use_transport_capacity = value; }
		}

		public override ArrayList Stt_lplayers
		{
			get { return stt_lplayers; }
			set { stt_lplayers = value; }
		}

		public override ArrayList Stt_oblevels
		{
			get { return stt_oblevels; }
			set { stt_oblevels = value; }
		}
		#endregion

		#region initializer
		public FLOStt(DrawArea drawArea)
		{
			Objtype = OBJTYPE.Stt;
			Init(0);

			GetLpLayers(drawArea);
			GetOBLevels(drawArea);

			PopUp(drawArea, new FormFLOStt(drawArea, this));
			this.Drwobj = new DRWStt(this,drawArea.ClientRectangle.Right,drawArea.ClientRectangle.Top);
		}
		#endregion

		#region init variables
		public override void Init(int n)
		{			
			stt_lplayers = new ArrayList();
			stt_oblevels = new ArrayList();

			stt_instanceid = "SDS_SCP";
			stt_bitposition = 1;
			stt_enterprise = "SDS_SCP_EP";
			stt_engine_id = (int)Math.Pow(2,(double)stt_bitposition);
			stt_supplychainid = "SDS_SCP_SC";
			stt_organizationid = "SDS_SCP_OG";
			stt_workcenter = "WORKCENTER";
			stt_planid = "PLAN";
			stt_planstartdate = DateTime.Now.ToShortDateString();
			stt_planenddate = DateTime.Now.ToShortDateString();
			stt_plancurrentdate = DateTime.Now.ToShortDateString();
			stt_bucketname = "LP_HORIZON";
			stt_boundaryid = "Planning_Cal";
			stt_firstdayofweek = 1;
			stt_effstartdate = DateTime.Now.ToShortDateString();	// Planhorizon;
			stt_patternsequence = 1;
			stt_bucketsize = 1;
			stt_bucketsizeuom = "day";
			stt_numberofbuckets = 1;
			stt_keep_or_better = 0;
			stt_export_unpegged_material = 1;
			stt_export_unpegged_capacity = 1;
			stt_export_date_range = 1;
			stt_export_source_peggings = 1;
			stt_mpa_solver = "FALSE";
			stt_use_transport_capacity = 1;

			this.Oldname = "FLO_Static_Data";
			this.Objname = "FLO_Static_Data";
			this.Disname = "Master";
		}
		#endregion

		#region GetLpLayers()
		public void GetLpLayers(DrawArea drawArea)
		{
			this.stt_lplayers.Clear();

			ArrayList prioritylist = drawArea.Mgr.Flolist.GetFLODmdPriorityList();

			foreach(int priority in prioritylist)
			{
				LPLayer layer;

				layer.stt_layername = "Layer" + priority.ToString();
				layer.stt_layertype = "S";
				layer.stt_priority = priority;
				layer.stt_demandprioritystart = priority;
				layer.stt_demandpriorityend = priority;
				layer.stt_demandbands = "";

				this.Stt_lplayers.Add(layer);
			}
		}

		public void GetOBLevels(DrawArea drawArea)
		{
			this.stt_oblevels.Clear();

			ArrayList Layers = this.Stt_lplayers;

			int x = 0;

			if(Layers.Count > 1)
                x = ((FLOStt.LPLayer)Layers[0]).stt_priority;

			foreach(FLOStt.LPLayer layer in Layers)
			{
				if( x < layer.stt_priority)	
					x = layer.stt_priority;
			}

			foreach(FLOStt.LPLayer layer in Layers)
			{
				FLOStt.OBLevel level;
				
				level.stt_oblevel = "amt_not_satisfied";
				level.stt_priority = x*1000 - layer.stt_priority*10;
				level.stt_istimeweighted = 0;						// 0 or 1
				level.stt_qualifier = layer.stt_layername;			// Layer, buffer.stage(), none
				level.stt_lpmethod = "P";							// P

				this.Stt_oblevels.Add(level);
				
				level.stt_oblevel = "backlog";
				level.stt_priority = x*1000 - layer.stt_priority*10 -1;
				level.stt_istimeweighted = 0;						// 0 or 1
				level.stt_qualifier = layer.stt_layername;			// Layer, buffer.stage(), none
				level.stt_lpmethod = "P";							// P

				this.Stt_oblevels.Add(level);
			}
		
		}
		#endregion

		#region popup properties
		public override bool PopUp(DrawArea drawArea, FormFLOStt f)
		{
			f.SetAttr(this);
			DialogResult r = f.ShowDialog();
			
			if(r == DialogResult.OK)
			{
				f.GetAttr(this);
				return true;
			}
			else
			{
				return false;
			}
		}
		#endregion

		#region entry variables
		private const string entrysttinstanceid = "stt_instanceid";
		private const string entrysttbitposition = "stt_bitposition";
		private const string entrysttenterprise = "stt_enterprise";
		private const string entrysttengineid = "stt_engine_id";
		private const string entrysttsupplychainid = "stt_supplychainid";
		private const string entrysttorganizationid = "stt_organizationid";
		private const string entrysttworkcentername = "stt_workcentername";
		private const string entrysttplanid = "stt_planid";
		private const string entrysttplanstartdate = "stt_planstartdate";
		private const string entrysttplanenddate = "stt_planenddate";
		private const string entrysttplancurrentdate = "stt_plancurrentdate";
		private const string entrysttbucketname = "stt_bucketname";
		private const string entrysttboundaryid = "stt_boundaryid";
		private const string entrysttfirstdayofweek = "stt_firstdayofweek";
		private const string entrystteffstartdate = "stt_effstartdate";
		private const string entrysttpatternsequence = "stt_patternsequence";
		private const string entrysttbucketsize = "stt_bucketsize";
		private const string entrysttbucketsizeuom = "stt_bucketsizeuom";
		private const string entrysttnumberofbuckets = "stt_numberofbuckets";
		private const string entrysttkeeporbetter = "stt_keep_or_better";
		private const string entrysttexportunpeggedmaterial = "stt_export_unpegged_material";
		private const string entrysttexportunpeggedcapacity = "stt_export_unpegged_capacity";
		private const string entrysttexportdaterange = "stt_export_date_range";
		private const string entrysttexportsourcepeggings = "stt_export_source_peggings";
		private const string entrysttmpasolver = "stt_mpa_solver";
		private const string entrysttusetransportcapacity = "stt_use_transport_capacity";
		private const string entrystt_lplayers = "stt_lplayers";
		private const string entrystt_oblevels = "stt_oblevels";
		#endregion

		#region dump
		public override void Dump()
		{
			base.Dump ();
		}
		#endregion

		#region savetostream
		public override void SaveToStream(System.Runtime.Serialization.SerializationInfo info, int orderNumber)
		{
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttinstanceid, orderNumber),stt_instanceid);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttbitposition, orderNumber),stt_bitposition);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttenterprise, orderNumber),stt_enterprise);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttengineid, orderNumber),stt_engine_id);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttsupplychainid, orderNumber),stt_supplychainid);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttorganizationid, orderNumber),stt_organizationid);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttworkcentername, orderNumber),stt_workcenter);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttplanid, orderNumber),stt_planid);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttplanstartdate, orderNumber),stt_planstartdate);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttplanenddate, orderNumber),stt_planenddate);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttplancurrentdate, orderNumber),stt_plancurrentdate);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttbucketname, orderNumber),stt_bucketname);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttboundaryid, orderNumber),stt_boundaryid);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttfirstdayofweek, orderNumber),stt_firstdayofweek);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrystteffstartdate, orderNumber),stt_effstartdate);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttpatternsequence, orderNumber),stt_patternsequence);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttbucketsize, orderNumber),stt_bucketsize);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttbucketsizeuom, orderNumber),stt_bucketsizeuom);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttnumberofbuckets, orderNumber),stt_numberofbuckets);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttkeeporbetter, orderNumber),stt_keep_or_better);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttexportunpeggedmaterial, orderNumber),stt_export_unpegged_material);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttexportunpeggedcapacity, orderNumber),stt_export_unpegged_capacity);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttexportdaterange, orderNumber),stt_export_date_range);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttexportsourcepeggings, orderNumber),stt_export_source_peggings);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttmpasolver, orderNumber),stt_mpa_solver);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttusetransportcapacity, orderNumber),stt_use_transport_capacity);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrystt_lplayers, orderNumber),stt_lplayers);
			info.AddValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrystt_oblevels, orderNumber),stt_oblevels);

			base.SaveToStream (info, orderNumber);
		}
		#endregion

		#region loadfromstream
		public override void LoadFromStream(SerializationInfo info, int orderNumber)
		{
			this.stt_instanceid = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttinstanceid, orderNumber),typeof(string));
			this.stt_bitposition = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttbitposition, orderNumber),typeof(int));
			this.stt_enterprise = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttenterprise, orderNumber),typeof(string));
			this.stt_engine_id = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttengineid, orderNumber),typeof(int));
			this.stt_supplychainid = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttsupplychainid, orderNumber),typeof(string));
			this.stt_organizationid = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttorganizationid, orderNumber),typeof(string));
			this.stt_workcenter = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttworkcentername, orderNumber),typeof(string));
			this.stt_planid = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttplanid, orderNumber),typeof(string));
			this.stt_planstartdate = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttplanstartdate, orderNumber),typeof(string));
			this.stt_planenddate = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttplanenddate, orderNumber),typeof(string));
			this.stt_plancurrentdate = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttplancurrentdate, orderNumber),typeof(string));
			this.stt_bucketname = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttbucketname, orderNumber),typeof(string));
			this.stt_boundaryid = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttboundaryid, orderNumber),typeof(string));
			this.stt_firstdayofweek = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttfirstdayofweek, orderNumber),typeof(int));
			this.stt_effstartdate = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrystteffstartdate, orderNumber),typeof(string));
			this.stt_patternsequence = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttpatternsequence, orderNumber),typeof(int));
			this.stt_bucketsize = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttbucketsize, orderNumber),typeof(int));
			this.stt_bucketsizeuom = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttbucketsizeuom, orderNumber),typeof(string));
			this.stt_numberofbuckets = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttnumberofbuckets, orderNumber),typeof(int));
			this.stt_keep_or_better = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttkeeporbetter, orderNumber),typeof(int));
			this.stt_export_unpegged_material = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttexportunpeggedmaterial, orderNumber),typeof(int));
			this.stt_export_unpegged_capacity = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttexportunpeggedcapacity, orderNumber),typeof(int));
			this.stt_export_date_range = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttexportdaterange, orderNumber),typeof(int));
			this.stt_export_source_peggings = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttexportsourcepeggings, orderNumber),typeof(int));
			this.stt_mpa_solver = (string)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttmpasolver, orderNumber),typeof(string));
			this.stt_use_transport_capacity = (int)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrysttusetransportcapacity, orderNumber),typeof(int));
			
			this.stt_lplayers = (ArrayList)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrystt_lplayers, orderNumber),typeof(ArrayList));
			this.stt_oblevels = (ArrayList)info.GetValue(String.Format(CultureInfo.InvariantCulture,"{0}{1}",entrystt_oblevels, orderNumber),typeof(ArrayList));

			base.LoadFromStream (info, orderNumber);
		}
		#endregion

		#region restorearraylist
		#endregion
	}
}
