using System.Collections.Generic;
using DocCN.Components;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace DocCN.Page
{
    public class DocumentPage : StatelessWidget
    {
        public override Widget build(BuildContext context)
        {
            var column = new Column(
                crossAxisAlignment: CrossAxisAlignment.stretch,
                children: new List<Widget>
                {
                    new Header(),
                    new Expanded(
                        child: new Container(
                            padding: EdgeInsets.only(top: 24.0f),
                            color: new Color(0xffffffff),
                            child: new Row(
                                children: new List<Widget>
                                {
                                    new Menu(),
                                    new Expanded(
                                        child: new Components.Markdown()
                                    ),
                                    new MetaFields()
                                }
                            )
                        )
                    )
                }
            );
            return column;
        }
    }
}