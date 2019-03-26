using System.Collections.Generic;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using TextStyle = Unity.UIWidgets.painting.TextStyle;

namespace DocCN.Components
{
    public class MetaFields : StatelessWidget
    {
        public override Widget build(BuildContext context)
        {
            return new Container(
                padding: EdgeInsets.only(
                    left: 48.0f,
                    right: 48.0f
                ),
                width: 324.0f,
                child: new Column(
                    crossAxisAlignment: CrossAxisAlignment.stretch,
                    children: new List<Widget>
                    {
                        new Container(
                            height: 64f,
                            padding: EdgeInsets.only(bottom: 8.0f),
                            child: new Align(
                                alignment: Alignment.bottomLeft,
                                child: new Text(
                                    "文章导览",
                                    style: new TextStyle(
                                        fontSize: 16f,
                                        color: new Color(0xff212121)
                                    )
                                )
                            )
                        ),
                        new Container(
                            height: 1f,
                            color: new Color(0xffd8d8d8)
                        ),
                        new RelatedArticles()
                    }
                )
            );
        }
    }
}