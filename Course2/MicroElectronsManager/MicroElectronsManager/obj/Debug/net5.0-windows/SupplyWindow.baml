   M S B A M L   `   `   `  ����P  LMicroElectronsManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MicroElectronsManagerMicroElectronsManager  5   	   (    "MicroElectronsManager.SupplyWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:MicroElectronsManager     5   	   -   5          � Title$  Поставки��5   	   $
��1366��6   $
��1366��6'   $	��768��67   $	��768��6D    � WindowState$ 	Maximized=�6T    � WindowStyle$ SingleBorderWindow=�6l    � WindowStartupLocation$ CenterScreen=�6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��120 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#212529.+�5      �� -   5         ��Name$ 	TbWelcome��5      $0��*Здравствуйте, юзернейм��6+   ���#ffffff$��18(�6^   $��Center=�6l   $��Center=�6�   �� 5      -   5         ��Name$ BtnExit��5      $��
Выход��6&   $
��Left=�66   $��Center=�6Q   $��20 0 0 0q�6l   $
��30 5q�6~   ���#ffffff���#ffffff���#212529$��15(�5   U   $��18(�6c   6{   �� 5      $��/res/logo.png��6   $��Right=�6+   $��
0 15 20 15q�6G   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridSupply��5      $��1��6+   $��Stretch=�68   $��Stretch=�6V   $��18(�6r      CanUserAddRows$ False��5      	   CanUserDeleteRows$	 False��6*   
   CanUserResizeRows$
 False��6D      AutoGenerateColumns$ False��6^      SelectionMode$ Single=�6z      RowHeaderWidth$ 0Q�5      $��2q�6&      HorizontalGridLinesBrush
 ��������#212529   GridLinesVisibility$ 
Horizontal=�5         	RowHeight$ 35Q�64      
IsReadOnly$
 True��6C    � ContextMenu 5      �� 5      .@�5      m� -   5         m�Name$ CmAdd��5      $'��!Добавить поставку��6.   6_   m� 5      -   5        $ CmCompos��5      $#��Состав поставки��61   ${�False��6b   6v   5         Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ Контрагент��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   ��  �� Path$ Counterparty�  5"      $ Тип поставки��6%   $	 160 6;    6G   �� $ 	SellOrBuy�  5#      $ 
Сумма��6%   $	 160 64    6@   �� $ Summa�  5$      $ Дата��6%   $	 160 63    6?   �� $
 Date�  5%      $ Id��6%   $ * 61      
Visibility$ 	Collapsed=�6]    6;   �� $ SupplyId�6]   5'      5(      5)      