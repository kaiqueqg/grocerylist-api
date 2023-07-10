﻿using System.Collections.Generic;

namespace GroceryList.Model.MongoDB
{
	public static class MongoDBExtensions
	{
		public static MongoDBItemModel FromModel(this ItemModel i) 
		{ 
			return new MongoDBItemModel() 
			{ 
				Id = i.id, 
				Text = i.text, 
				IsChecked = i.isChecked, 
				MyCategory = i.myCategory 
			}; 
		}
		public static ItemModel ToModel(this MongoDBItemModel i)
		{
			return new ItemModel()
			{
				id = i.Id,
				text = i.Text,
				isChecked = i.IsChecked,
				myCategory = i.MyCategory
			};
		}

		public static MongoDBCategoryModel FromModel(this CategoryModel c) 
		{ 
			return new MongoDBCategoryModel() 
			{ 
				Id = c.id, 
				Text = c.text, 
				IsOpen = c.isOpen
			}; 
		}
		public static CategoryModel ToModel(this MongoDBCategoryModel c)
		{
			return new CategoryModel()
			{
				id = c.Id,
				text = c.Text,
				isOpen = c.IsOpen
			};
		}

		public static List<MongoDBCategoryModel> FromModelList(this List<CategoryModel> list)
		{
			List<MongoDBCategoryModel> rtnList = new List<MongoDBCategoryModel>();
			foreach(CategoryModel i in list)
			{
				rtnList.Add(i.FromModel());
			}

			return rtnList;
		}
		public static List<MongoDBItemModel> FromModelList(this List<ItemModel> list)
		{
			List<MongoDBItemModel> rtnList = new List<MongoDBItemModel>();
			foreach(ItemModel i in list)
			{
				rtnList.Add(i.FromModel());
			}

			return rtnList;
		}

		public static List<CategoryModel> ToModelList(this List<MongoDBCategoryModel> list)
		{
			List<CategoryModel> catList = new List<CategoryModel>();

			foreach(MongoDBCategoryModel c in list)
			{
				catList.Add(c.ToModel());
			}

			return catList;
		}
		public static List<ItemModel> ToModelList(this List<MongoDBItemModel> list)
		{
			List<ItemModel> rtnList = new List<ItemModel>();

			foreach(MongoDBItemModel i in list)
			{
				rtnList.Add(i.ToModel());
			}

			return rtnList;
		}
	}
}