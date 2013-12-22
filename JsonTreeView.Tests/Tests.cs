using System.Windows.Forms;
using ApprovalTests.Reporters;
using ApprovalTests.WinForms;
using NUnit.Framework;

namespace JsonTreeView.Tests
{
	[TestFixture]
	[UseReporter(typeof(DiffReporter), typeof(ClipboardReporter))]
	public class Tests
	{
		[Test]
		public void Should_work_with_null()
		{
			var treeView = GetTreeView(null);

			WinFormsApprovals.Verify(treeView);
		}

		[Test]
		public void Should_work_with_empty_string()
		{
			var treeView = GetTreeView(string.Empty);

			WinFormsApprovals.Verify(treeView);
		}

		[Test]
		public void Should_work_with_empty_json_object()
		{
			var treeView = GetTreeView("{}");

			WinFormsApprovals.Verify(treeView);
		}

		[Test]
		public void Should_work_with_simple_name_value()
		{
			var treeView = GetTreeView("{ 'the_answer': 42 }");

			WinFormsApprovals.Verify(treeView);
		}

		[Test]
		public void Should_work_with_nested_objects()
		{
			var treeView = GetTreeView("{ 'the_answer': { 'to_the': { 'universe_is': 42 } } }");

			WinFormsApprovals.Verify(treeView);
		}

		[Test]
		public void Should_work_with_arrays()
		{
			var treeView = GetTreeView("{ 'foo': [ 'bar', 'baz', 'quux' ] }");

			WinFormsApprovals.Verify(treeView);
		}

		[Test]
		public void Should_work_with_nested_arrays()
		{
			var treeView = GetTreeView("{ 'foo': [ 'bar', [ 'sheldon', 'cooper', 'leonard', 'hofstadter' ], 'quux' ] }");

			WinFormsApprovals.Verify(treeView);
		}

		[Test]
		public void Should_work_with_objects_in_arrays()
		{
			var treeView = GetTreeView("{ 'foo': [ 'bar', { 'sheldon': 'cooper', 'leonard': 'hofstadter' }, 'quux' ] }");

			WinFormsApprovals.Verify(treeView);
		}

		[Test]
		public void Should_work_with_this_complex_object()
		{
			var treeView = GetTreeView(@"{
	'id': '0001',
	'type': 'donut',
	'batters':
	{
		'batter':
		[
			{ 'id': '1001', 'type': 'Regular' },
			{ 'id': '1002', 'type': 'Chocolate' },
		]
	},
	'topping':
	[
		{ 'id': '5001', 'type': 'None' },
		{ 'id': '5002', 'type': 'Glazed', 'tags': [ 'foo', 'bar' ] }
	],
	'name': 'Cake',
	'ppu': 0.55,
}");

			WinFormsApprovals.Verify(treeView);
		}

		private TreeView GetTreeView(string json)
		{
			var treeView = new TreeView
			{
				BorderStyle = BorderStyle.None, 
				Width = 400, 
				Height = 400,
			};

			treeView.LoadJsonToTreeView(json);
			treeView.ExpandAll();

			return treeView;
		}
	}
}