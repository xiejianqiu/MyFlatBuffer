// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CardBase : Table {
  public static FB_CardBase GetRootAsFB_CardBase(ByteBuffer _bb) { return GetRootAsFB_CardBase(_bb, new FB_CardBase()); }
  public static FB_CardBase GetRootAsFB_CardBase(ByteBuffer _bb, FB_CardBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CardBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string CardName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Tips { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int LogType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Quality { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string CardImage { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public string CardIcon { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public int CompoundId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DecomposeId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetWayStrId { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetStarmapIDList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int StarmapIDListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CardBase> CreateFB_CardBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset CardName = default(StringOffset),
      StringOffset Tips = default(StringOffset),
      int LogType = 0,
      int Quality = 0,
      StringOffset CardImage = default(StringOffset),
      StringOffset CardIcon = default(StringOffset),
      int CompoundId = -1,
      int DecomposeId = -1,
      int GetWayStrId = -1,
      VectorOffset StarmapID_List = default(VectorOffset)) {
    builder.StartObject(11);
    FB_CardBase.AddStarmapIDList(builder, StarmapID_List);
    FB_CardBase.AddGetWayStrId(builder, GetWayStrId);
    FB_CardBase.AddDecomposeId(builder, DecomposeId);
    FB_CardBase.AddCompoundId(builder, CompoundId);
    FB_CardBase.AddCardIcon(builder, CardIcon);
    FB_CardBase.AddCardImage(builder, CardImage);
    FB_CardBase.AddQuality(builder, Quality);
    FB_CardBase.AddLogType(builder, LogType);
    FB_CardBase.AddTips(builder, Tips);
    FB_CardBase.AddCardName(builder, CardName);
    FB_CardBase.AddID(builder, ID);
    return FB_CardBase.EndFB_CardBase(builder);
  }

  public static void StartFB_CardBase(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCardName(FlatBufferBuilder builder, StringOffset CardNameOffset) { builder.AddOffset(1, CardNameOffset.Value, 0); }
  public static void AddTips(FlatBufferBuilder builder, StringOffset TipsOffset) { builder.AddOffset(2, TipsOffset.Value, 0); }
  public static void AddLogType(FlatBufferBuilder builder, int LogType) { builder.AddInt(3, LogType, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(4, Quality, 0); }
  public static void AddCardImage(FlatBufferBuilder builder, StringOffset CardImageOffset) { builder.AddOffset(5, CardImageOffset.Value, 0); }
  public static void AddCardIcon(FlatBufferBuilder builder, StringOffset CardIconOffset) { builder.AddOffset(6, CardIconOffset.Value, 0); }
  public static void AddCompoundId(FlatBufferBuilder builder, int CompoundId) { builder.AddInt(7, CompoundId, -1); }
  public static void AddDecomposeId(FlatBufferBuilder builder, int DecomposeId) { builder.AddInt(8, DecomposeId, -1); }
  public static void AddGetWayStrId(FlatBufferBuilder builder, int GetWayStrId) { builder.AddInt(9, GetWayStrId, -1); }
  public static void AddStarmapIDList(FlatBufferBuilder builder, VectorOffset StarmapIDListOffset) { builder.AddOffset(10, StarmapIDListOffset.Value, 0); }
  public static VectorOffset CreateStarmapIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartStarmapIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CardBase> EndFB_CardBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CardBase>(o);
  }
};

public sealed class FB_CardBaseContainer : Table {
  public static FB_CardBaseContainer GetRootAsFB_CardBaseContainer(ByteBuffer _bb) { return GetRootAsFB_CardBaseContainer(_bb, new FB_CardBaseContainer()); }
  public static FB_CardBaseContainer GetRootAsFB_CardBaseContainer(ByteBuffer _bb, FB_CardBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CardBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CardBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CardBase GetItems(int j) { return GetItems(new FB_CardBase(), j); }
  public FB_CardBase GetItems(FB_CardBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CardBaseContainer> CreateFB_CardBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CardBaseContainer.AddItems(builder, items);
    return FB_CardBaseContainer.EndFB_CardBaseContainer(builder);
  }

  public static void StartFB_CardBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CardBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CardBaseContainer> EndFB_CardBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CardBaseContainer>(o);
  }
  public static void FinishFB_CardBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_CardBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
