// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ChiJiBase : Table {
  public static FB_ChiJiBase GetRootAsFB_ChiJiBase(ByteBuffer _bb) { return GetRootAsFB_ChiJiBase(_bb, new FB_ChiJiBase()); }
  public static FB_ChiJiBase GetRootAsFB_ChiJiBase(ByteBuffer _bb, FB_ChiJiBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ChiJiBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int QuanTime { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PeopleNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetNextQuanIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int NextQuanIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GroupPointId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Radii { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float PosX { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosY { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int BuffId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetGroupPointIdList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int GroupPointIdListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int GetGroupPointNumList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int GroupPointNumListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int GetGroupPointPosList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int GroupPointPosListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int ChuanSongDianId { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ChuanSongDianPos { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_ChiJiBase> CreateFB_ChiJiBase(FlatBufferBuilder builder,
      int Id = 0,
      int QuanTime = 0,
      int PeopleNum = 0,
      VectorOffset NextQuanIdList = default(VectorOffset),
      int GroupPointId = 0,
      int Radii = 0,
      float PosX = 0,
      float PosY = 0,
      int BuffId = 0,
      VectorOffset GroupPointIdList = default(VectorOffset),
      VectorOffset GroupPointNumList = default(VectorOffset),
      VectorOffset GroupPointPosList = default(VectorOffset),
      int ChuanSongDianId = 0,
      int ChuanSongDianPos = 0) {
    builder.StartObject(14);
    FB_ChiJiBase.AddChuanSongDianPos(builder, ChuanSongDianPos);
    FB_ChiJiBase.AddChuanSongDianId(builder, ChuanSongDianId);
    FB_ChiJiBase.AddGroupPointPosList(builder, GroupPointPosList);
    FB_ChiJiBase.AddGroupPointNumList(builder, GroupPointNumList);
    FB_ChiJiBase.AddGroupPointIdList(builder, GroupPointIdList);
    FB_ChiJiBase.AddBuffId(builder, BuffId);
    FB_ChiJiBase.AddPosY(builder, PosY);
    FB_ChiJiBase.AddPosX(builder, PosX);
    FB_ChiJiBase.AddRadii(builder, Radii);
    FB_ChiJiBase.AddGroupPointId(builder, GroupPointId);
    FB_ChiJiBase.AddNextQuanIdList(builder, NextQuanIdList);
    FB_ChiJiBase.AddPeopleNum(builder, PeopleNum);
    FB_ChiJiBase.AddQuanTime(builder, QuanTime);
    FB_ChiJiBase.AddId(builder, Id);
    return FB_ChiJiBase.EndFB_ChiJiBase(builder);
  }

  public static void StartFB_ChiJiBase(FlatBufferBuilder builder) { builder.StartObject(14); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddQuanTime(FlatBufferBuilder builder, int QuanTime) { builder.AddInt(1, QuanTime, 0); }
  public static void AddPeopleNum(FlatBufferBuilder builder, int PeopleNum) { builder.AddInt(2, PeopleNum, 0); }
  public static void AddNextQuanIdList(FlatBufferBuilder builder, VectorOffset NextQuanIdListOffset) { builder.AddOffset(3, NextQuanIdListOffset.Value, 0); }
  public static VectorOffset CreateNextQuanIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartNextQuanIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGroupPointId(FlatBufferBuilder builder, int GroupPointId) { builder.AddInt(4, GroupPointId, 0); }
  public static void AddRadii(FlatBufferBuilder builder, int Radii) { builder.AddInt(5, Radii, 0); }
  public static void AddPosX(FlatBufferBuilder builder, float PosX) { builder.AddFloat(6, PosX, 0); }
  public static void AddPosY(FlatBufferBuilder builder, float PosY) { builder.AddFloat(7, PosY, 0); }
  public static void AddBuffId(FlatBufferBuilder builder, int BuffId) { builder.AddInt(8, BuffId, 0); }
  public static void AddGroupPointIdList(FlatBufferBuilder builder, VectorOffset GroupPointIdListOffset) { builder.AddOffset(9, GroupPointIdListOffset.Value, 0); }
  public static VectorOffset CreateGroupPointIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartGroupPointIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGroupPointNumList(FlatBufferBuilder builder, VectorOffset GroupPointNumListOffset) { builder.AddOffset(10, GroupPointNumListOffset.Value, 0); }
  public static VectorOffset CreateGroupPointNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartGroupPointNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGroupPointPosList(FlatBufferBuilder builder, VectorOffset GroupPointPosListOffset) { builder.AddOffset(11, GroupPointPosListOffset.Value, 0); }
  public static VectorOffset CreateGroupPointPosListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartGroupPointPosListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddChuanSongDianId(FlatBufferBuilder builder, int ChuanSongDianId) { builder.AddInt(12, ChuanSongDianId, 0); }
  public static void AddChuanSongDianPos(FlatBufferBuilder builder, int ChuanSongDianPos) { builder.AddInt(13, ChuanSongDianPos, 0); }
  public static Offset<FB_ChiJiBase> EndFB_ChiJiBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChiJiBase>(o);
  }
};

public sealed class FB_ChiJiBaseContainer : Table {
  public static FB_ChiJiBaseContainer GetRootAsFB_ChiJiBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ChiJiBaseContainer(_bb, new FB_ChiJiBaseContainer()); }
  public static FB_ChiJiBaseContainer GetRootAsFB_ChiJiBaseContainer(ByteBuffer _bb, FB_ChiJiBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ChiJiBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ChiJiBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ChiJiBase GetItems(int j) { return GetItems(new FB_ChiJiBase(), j); }
  public FB_ChiJiBase GetItems(FB_ChiJiBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChiJiBaseContainer> CreateFB_ChiJiBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ChiJiBaseContainer.AddItems(builder, items);
    return FB_ChiJiBaseContainer.EndFB_ChiJiBaseContainer(builder);
  }

  public static void StartFB_ChiJiBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ChiJiBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChiJiBaseContainer> EndFB_ChiJiBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChiJiBaseContainer>(o);
  }
  public static void FinishFB_ChiJiBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ChiJiBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
