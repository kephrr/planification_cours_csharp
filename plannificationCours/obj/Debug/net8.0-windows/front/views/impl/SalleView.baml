   M S B A M L   `   `   `  ����N  JplannificationCours, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:plannificationCours.front.views.impl$plannificationCours.front.views.impl  5   	   4    .plannificationCours.front.views.impl.SalleView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:plannificationCours.front.views.impl     5   	     � Title$  	SalleView��5   	   $	��450��6   $	��800��6(   .��5	      � .+�5
   
   �� $��Ajout salle��6   $
��Left=�6&   $��33��6A   $��	48,47,0,0q�6M   $	��Top=�6`   $	��109��6x   $��18(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ inputSalleName��5      $
��Left=�6*   $��30��6E   $��	66,85,0,0q�6Q    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��246��6�   $��18(�6�   �� 5   
   -   5         ��Name$ btnAddSalle��5      $	��ADD��6&   $
��Left=�64   $��30��6O   $��519,115,0,0q�6[   $	��Top=�6p   $��71��6�   $��18(�6�   �� 5   
   -   5        $ 
btnUpSalle��5      $��UP��6%   $
��Left=�62   $��30��6M   $��612,115,0,0q�6Y   $	��Top=�6n   $��74��6�   $��18(�6�   �� 5   
   -   5        $ btnDelSalle��5      $	��DEL��6&   $
��Left=�64   $��30��6O   $��705,115,0,0q�6[   $	��Top=�6p   $��71��6�   $��18(�6�   �� 5   
   $��Liste Salle��6   $
��Left=�6&   $��31��6A   $��
48,193,0,0q�6M   $	��Top=�6a   $��95��6y   $��18(�6�   $
��Bold"�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgvSalle��5      $
��Left=�6%   $	��170��6@   $��
66,243,0,0q�6M   $	��Top=�6a   $	��620��6y   6�   �� 5   
   -   5        $ salleId��5      $
��Left=�6#   $��15��6>   $��312,130,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $��32��6�   5      5      