   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Client.DataAccessServiceClient.DataAccessService  5   	   C ?Entities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK3clr-namespace:Entities.ViewModels;assembly=EntitiesEntities.ViewModels 5   	       Client.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   DDataAccessService&clr-namespace:Client.DataAccessService     5   	   J
viewModels3clr-namespace:Entities.ViewModels;assembly=Entities     5   	     � Title$  
MainWindow��5   	   $	��402��6   $	��649��6)   
������� J� OpacityMask
 �   � � 
ResizeMode$ NoResize=�6\    � WindowStartupLocation$ CenterScreen=�6r   ��5      �� 5	   
    �� EndPoint$ 0.5,1&�6    � MappingMode$ RelativeToBoundingBox=�6/    �� 
StartPoint$ 0.5,0&�6S   .��5
      �  � Color$ 	#FF060100��6    � Offset$ 1Q�6-   � 5      $ 	#FFFD7DDA��6   � 5      $ 	#FF99190C��6   $ 0.924Q�6-   � 5      $ 	#FF7474FF��6   $ 0.681Q�6-   � 5      $ 	#FFB9FF00��6   $ 0.402Q�6-   5      .��5      � .+�5   
   �� -   5        $��TabControl_DataView��5      $
��Left=�60   $	��332��6K   $��	28,10,0,0q�6X   $	��Top=�6k   $	��495��6�   .@�5      �� -   5        $��TabItem_Users��5      $��Users��6+   $��	0,0,-4,-3q�6:   .��5      &   System.Windows.Controls.DataGrid  -   5        $��DataGrid_Users��5      ���	#FFE5E5E5	   AutoGenerateColumns	 .  
 � DataContext
 5      "  Entities.ViewModels.ViewUser  5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ UserID��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *UserID+  5      $
 Name��6-    6;   �� *Name+  5      $ Surname��6-    6>   �� *	Surname+  5      $ PhoneNumber��6-    6B   �� *PhoneNumber+  5      $ Email��6-    6<   �� *Email+5      5       �� 5!      -   5        $��TabItem_ObjOfTransact��5!      $��ObjOfTransact��63   $��
7,0,-11,-3q�6J   .��5"        -   5        $��DataGrid_ObjOfTransact��5"      ���	#FFE5E5E5	 .  
 5#      +  %Entities.ViewModels.ViewObjOfTransact  5$       5&        5'      $ ObjID��6-    6<   �� *ObjectOfTransactionID+  5(      $ UserID��6-    6=   �� *UserID+  5)      $ UserInfo��6-    6?   �� *
UserInfo+  5+      $ 
ObjectType��6-    6A   �� *
ObjectType+  5,      $ ServiceType��6-    6B   �� *ServiceType+  5-      $ KindOfCalculating��6-    6H   �� *KindOfCalculating+  5.      $ ObjectState��6-    6B   �� *ObjectState+  50      $
 Cost��6-    6;   �� *Cost+  51      $ Description��6-    6B   �� *Description+53      54      �� 55      -   5        $��TabItem_Deals��55      $��Deals��6+   $��14,0,-18,-3q�6:   .��56        -   5        $��DataGrid_Deals��56      ���	#FFE5E5E5	 .  
 57      "  Entities.ViewModels.ViewDeal  58       5:        5;      $ DealID��6-    6=   �� *DealID+  5<      $ ObjectOfTransactionID��6-    6L   �� *ObjectOfTransactionID+  5=      $ Seller_UserID��6-    6D   �� *Seller_UserID+  5>      $ Buyer_UserID��6-    6C   �� *Buyer_UserID+  5@      $ PersonalNumberOfDeal��6-    6K   �� *PersonalNumberOfDeal+  5A      $ 
SellerInfo��6-    6A   �� *
SellerInfo+  5B      $ 	BuyerInfo��6-    6@   �� *	BuyerInfo+  5C      $ ObjectOfTransactionInfo��6-    6N   �� *ObjectOfTransactionInfo+  5E      $ KindOfCalculatingID��6-    6J   �� *KindOfCalculatingID+  5F      $ 
DateOfDeal��6-    6A   �� *
DateOfDeal+  5G      $ TransactionAmount��6-    6H   �� *TransactionAmount+5I      5J      5K      �� 5L   
   -   5        $	��Add��5L      $
��Left=�6   $��
537,32,0,0q�6:   $	��Top=�6N   $��75��6f   ���	#FF39BF1B6�   �� 5M   
   -	   5        $��Correct��5M      $
��Left=�6#   $��
537,59,0,0q�6>   $	��Top=�6R   $��75��6j   ���	#FFEC9F186�   �� 5N   
   -
   5        $��Delete��5N      $
��Left=�6"   $��
537,86,0,0q�6=   $	��Top=�6Q   $��75��6i   ���	#FFD818186�   �� 5O   
   -   5        $��TextBox_SearchValue��5O      $
��Left=�6-   $��23��6H   $��537,218,0,0q�6T    �� TextWrapping$
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $��88��6�   �� 5P   
   -   5        $��CheckBox_ActivateSearch��5P      $��Activate Serach��62   $
��Left=�6L   $��528,197,0,0q�6g   $	��Top=�6|   6�   �� 5Q   
   -   5        $��Button_Search��5Q      $
��Find��6&   $
��Left=�65   $��537,246,0,0q�6P   $	��Top=�6e   $��75��6}   ���	#FF45E2EA6�   �� 5R   
   -   5         ��Name$ Chart��5R      $��Chart��6    $
��Left=�60   $��537,133,0,0q�6K   $	��Top=�6`   $��75��6x   ���	#FF6188F06�   5T      5U      