using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace PluralSightDemo.Core.Regions
{
    public class StackPanelRegionAdapter : RegionAdapterBase<StackPanel>
    {
        public StackPanelRegionAdapter(IRegionBehaviorFactory rbf) : base(rbf)
        {
        
        }

        protected override IRegion CreateRegion() => new Region();
        
        /// <summary>
        /// Adapts region ot region target of type StackPanel
        /// </summary>
        /// <param name="region">Region that should be adapted</param>
        /// <param name="regionTarget">Control that should be adapted to</param>
        protected override void Adapt(IRegion region, StackPanel regionTarget)
        {
            //Add method to region event
            region.Views.CollectionChanged += (s, e) =>
            {
                //If adding region
                if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                {
                    //Loop FrameWork elements in New Items
                    foreach (FrameworkElement item in e.NewItems)
                    {
                        //Add items to collection
                        regionTarget.Children.Add(item);
                    }
                }
                //If removing
                else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove) 
                {
                    //Loop FrameWork elements in New Items
                    foreach (FrameworkElement item in e.OldItems)
                    {
                        //Remove items from collection
                        regionTarget.Children.Remove(item);
                    }
                }
            };
        }
    }
}
