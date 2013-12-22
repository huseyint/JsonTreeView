using System;
using System.Windows.Forms;

namespace JsonTreeView
{
	public partial class MainForm : Form
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

		public MainForm()
		{
			InitializeComponent();

			JsonTreeView.LoadJsonToTreeView(@"{
	'id': '0001',
	'type': 'donut',
	'name': 'Cake',
	'ppu': 0.55,
	'batters':
		{
			'batter':
				[
					{ 'id': '1001', 'type': 'Regular' },
					{ 'id': '1002', 'type': 'Chocolate' },
					{ 'id': '1003', 'type': 'Blueberry' },
					{ 'id': '1004', 'type': 'Devil\'s Food' }
				]
		},
	'topping':
		[
			{ 'id': '5001', 'type': 'None' },
			{ 'id': '5002', 'type': 'Glazed' },
			{ 'id': '5005', 'type': 'Sugar' },
			{ 'id': '5007', 'type': 'Powdered Sugar' },
			{ 'id': '5006', 'type': 'Chocolate with Sprinkles' },
			{ 'id': '5003', 'type': 'Chocolate' },
			{ 'id': '5004', 'type': 'Maple' }
		]
}");
			JsonTreeView.ExpandAll();
		}
	}
}