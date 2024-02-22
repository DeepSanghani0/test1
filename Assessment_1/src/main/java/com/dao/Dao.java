package com.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import com.model.Model;


public class Dao 
{
	public static Connection getconnect()
	{
		Connection con = null;
		
		try 
		{
			Class.forName("com.mysql.jdbc.Driver");
			con = DriverManager.getConnection("jdbc:mysql://localhost:3306/assessment1","root","");
		}
		catch (Exception e) 
		{
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		return con;
	}
	
	public static int savedata(Model m)
	{
		int status = 0;
		
		Connection con = Dao.getconnect();
		
		try 
		{
			PreparedStatement ps = con.prepareStatement("insert into product(name,price,quantity,company) values (?,?,?,?)");
			
			ps.setString(1,m.getName());
			ps.setString(2,m.getPrice());
			ps.setString(3,m.getQuantity());
			ps.setString(4,m.getCompany());
			
			status = ps.executeUpdate();
		} 
		catch (SQLException e) 
		{
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return status;
		
		
	}
	
	public static List<Model> viewdata()
	{
		Connection con = Dao.getconnect();
		ArrayList<Model> list = new ArrayList();
		try 
		{
			PreparedStatement	ps = con.prepareStatement("select * from product");
			
			ResultSet set =ps.executeQuery();
			
			while(set.next())
			{
				int id = set.getInt(1);
				String name = set.getString(2);
				String price = set.getString(3);
				String quantity = set.getString(4);
				String company= set.getString(5);
				
				Model m = new Model();
				m.setId(id);
				m.setName(name);
				m.setPrice(price);
				m.setQuantity(quantity);
				m.setCompany(company);
			
				list.add(m);
			}
		
		
		}
		catch (Exception e)
		{
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	
		return list;
	
	}
	
	public static int deletedata(int id)
	{
		int status = 0;
		Connection con = Dao.getconnect();
		try 
		{
			PreparedStatement ps = con.prepareStatement("delete from product where id=?");
			ps.setInt(1,id);
			status = ps.executeUpdate();
		}
		catch (Exception e) 
		{
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return status;
	}
	
	//edit
	
	public static Model getdetailbyid(int id)
	{
		Model m = new Model();
		
		Connection con = Dao.getconnect();
		try 
		{
			PreparedStatement ps = con.prepareStatement("Select * from product where id=?");
			ps.setInt(1,id);
			ResultSet set = ps.executeQuery();
			
			if(set.next())
			{
				int id1 = set.getInt(1);
				String name = set.getString(2);
				String price = set.getString(3);
				String quantity = set.getString(4);
				String company = set.getString(5);
				
				m.setId(id1);
				m.setName(name);
				m.setPrice(price);
				m.setQuantity(quantity);
				m.setCompany(company);
			}
		} 
		catch (Exception e) 
		{
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		
		return m;
	}
	
	public static int updatedata(Model m)
	{
		int status = 0;
		Connection con = Dao.getconnect();
		try 
		{
			PreparedStatement ps = con.prepareStatement("update product set name=?,price=?,quantity=?,company=? where id=?");
			
			ps.setString(1,m.getName());
			ps.setString(2,m.getPrice());
			ps.setString(3,m.getQuantity());
			ps.setString(4,m.getCompany());
			ps.setInt(5,m.getId());
			
			status = ps.executeUpdate();
		
		}
		catch (Exception e) 
		{
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return status;
	}
	

}