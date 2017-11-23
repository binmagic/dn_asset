/*
 * <auto-generated>
 *	 The code is generated by tools
 *	 Edit manually this code will lead to incorrect behavior
 * </auto-generated>
 */

#pragma once
#include"NativeReader.h"
#include <vector>
#include"Log.h"

struct QteStatusListRow
{
	
	char comment[MaxStringSize];
	char name[MaxStringSize];
	int value;
};

class QteStatusList:public NativeReader
{
public:
	QteStatusList(void);
	void ReadTable();
	void GetRow(int val,QteStatusListRow* row);
	int GetLength();

protected:
	std::string name;
	std::vector<QteStatusListRow> m_data;
};


extern "C"
{
	ENGINE_INTERFACE_EXPORT int iGetQteStatusListLength();
	ENGINE_INTERFACE_EXPORT void iGetQteStatusListRow(int idx,QteStatusListRow* row);
};