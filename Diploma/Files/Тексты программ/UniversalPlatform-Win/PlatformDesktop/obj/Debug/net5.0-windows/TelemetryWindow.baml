   M S B A M L   `   `   `  ����b  ^Syncfusion.SfChart.WPF, Version=19.4500.0.52, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89eGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPFSyncfusion.UI.Xaml.Charts  5   	   U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5   	   J FPlatformDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PlatformDesktopPlatformDesktop 5	   	   %   PlatformDesktop.TelemetryWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   YchartGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPF     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PlatformDesktop     5	   	   -   5          � Title$  TelemetryWindow��5   	   $	��850��6!   $
��1480��6.    � WindowStartupLocation$ CenterScreen=�6R    � DataContext 5      ( "PlatformDesktop.TelemetryViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $	��250 �6   5      �� 5      $��30 �6   �� 5      $	��250 �6   �� 5      $��30 �6   �� 5      $	��200 �6   �� 5      $��* �6   �� 5       � ColumnDefinitions 5   
   �� 5      $	��620 �6   �� 5      $	��100 �6   �� 5       $	��100 �6   �� 5!      $��* �6   .+�5%   
   #  LiveCharts.Wpf.CartesianChart  &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$
 Left=�67      Series 6   �� *Series+   AxisX 5'        LiveCharts.Wpf.Axis     Title$ X��6   	   LabelFormatter	 6%   �� *
FormatterX+
   Labels
 6K   �� *	BarLabels+6j      AxisY 5*        $ Y��6   	 6%   �� *	Formatter+6L   5,      �� 5-   
   $��4,4,0,0q�6   $��1��6&    �� Orientation$ 
Horizontal=�63   .+�5.      �� $��Гиросокп��6   $��15(�6'   $��4,-4,5,0q�65   	� 5/      $��ON��6   $
��Left=�6W   $��4q�6s   $	��Top=�6~    d� 	IsChecked 6'   �� *OnTelemetry+ �� Mode$ TwoWay=�6~   	� 50      $	��OFF��6   $
��Left=�6(   $��4q�6C   $	��Top=�6P   52      �� 53   
   $��4,4,0,0q�6   $��1��6&   $ Vertical=�66   .+�54      �� $��X��6   $��4q�6K    6#   �� *OnX+$ TwoWay=�6K   �� 55      $��Y��6   $��4q�6J    6#   �� *OnY+$ TwoWay=�6J   �� 56      $��Z��6   $��4q�6J    6#   �� *OnZ+$ TwoWay=�6J   58        5:   
   $��3��68   $
 Left=�6I   $��
20,0,-20,0q�6_    6   �� *	SeriesA+ 5<        $ X��6   	 6%   �� *FormatterXA+
 6L   �� *BarLabelsа+6l    5?        $ Y��6   	 6%   �� *
FormatterA+6M   5A      �� 5B   
   $��4,4,0,0q�6   $��1��6&   $��3��64   $ 
Horizontal=�6D   .+�5C      �� $��Акселерометр��6   $��15(�6+   $��4,-4,5,0q�69   	� 5D      $��ON��6   $
��Left=�6X   $��4q�6t   $	��Top=�6    6'   �� *OnTelemetryA+$ TwoWay=�6   	� 5E      $	��OFF��6   $
��Left=�6(   $��4q�6C   $	��Top=�6P   5F      �� 5G   
   $��50,4,4,4q�6   $��2��6'   $ Vertical=�67   .+�5H      �� $��X��6   $��4q�6L    6#   �� *OnXa+$ TwoWay=�6L   �� 5I      $��Y��6   $��4q�6K    6#   �� *OnYa+$ TwoWay=�6K   �� 5J      $��Z��6   $��4q�6K    6#   �� *OnZa+$ TwoWay=�6K   5K        5M   
   $��0��68   $��2��6H   $
 Left=�6V    6   �� *	SeriesM+ 5O        $ X��6   	 6%   �� *FormatterXM+
 6L   �� *
BarLabelsm+6l    5R        $ Y��6   	 6%   �� *
FormatterM+6M   5T      �� 5U   
   $��4,4,0,0q�6   $��3��6&   $��0��64   $ 
Horizontal=�6D   .+�5V      �� $��Магнитометр��6   $��15(�6*   $��4,-4,5,0q�68   	� 5W      $��ON��6   $
��Left=�6X   $��4q�6t   $	��Top=�6    6'   �� *OnTelemetryM+$ TwoWay=�6   	� 5X      $	��OFF��6   $
��Left=�6(   $��4q�6C   $	��Top=�6P   5Y      �� 5Z   
   $��4,4,4,4q�6   $��1��6&   $��2��66   $ Vertical=�6C   .+�5[      �� $��X��6   $��4q�6L    6#   �� *OnXm+$ TwoWay=�6L   �� 5\      $��Y��6   $��4q�6K    6#   �� *OnYm+$ TwoWay=�6K   �� 5]      $��Z��6   $��4q�6K    6#   �� *OnZm+$ TwoWay=�6K   5^        5a   
   $��3��6;   $��2��6K   $
 Left=�6Y    6   �� *
SeriesCurr+ 5c        $ X��6   	 6%   �� *FormatterCurrX+
 6O   �� *BarLabelscurr+6r    5f        $ Y��6   	 6%   �� *FormatterCurr+6P   5h      �� 5i   
   $��4,4,0,0q�6   $��3��6&   $��3��64   $ 
Horizontal=�6D   .+�5j      �� $��Ток��6   $��15(�6"   $��4,-4,5,0q�60   	� 5k      $��ON��6   $
��Left=�6[   $��4q�6w   $	��Top=�6�    6'   �� *OnTelemetryCurr+$ TwoWay=�6�   	� 5l      $	��OFF��6   $
��Left=�6(   $��4q�6C   $	��Top=�6P   5m      �� 5n   
   $��30,4,4,4q�6   $��2��6'   $��2��67   $ Vertical=�6D   .+�5o      �� $
��Left��6   $��4q�6R    6&   �� *	OnLcurr+$ TwoWay=�6R   �� 5p      $��Right��6   $��4q�6R    6'   �� *	OnRcurr+$ TwoWay=�6R   5r        5t   
   $��0��68   $��4��6H   $
 Left=�6V    6   �� *	SeriesV+ 5v        $ X��6   	 6%   �� *FormatterXV+
 6L   �� *
BarLabelsv+6l    5y        $ Y��6   	 6%   �� *
FormatterV+6M   5{      �� 5|   
   $��4,4,0,0q�6   $��5��6&   $��0��64   $ 
Horizontal=�6D   .+�5}      �� $��Батарея��6   $��15(�6&   $��4,-4,5,0q�64   	� 5~      $��ON��6   $
��Left=�6X   $��4q�6t   $	��Top=�6    6'   �� *OnTelemetryV+$ TwoWay=�6   	� 5      $	��OFF��6   $
��Left=�6(   $��4q�6C   $	��Top=�6P   5�      5�      5�      