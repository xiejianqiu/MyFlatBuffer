// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EternalTreasure : Table {
  public static FB_EternalTreasure GetRootAsFB_EternalTreasure(ByteBuffer _bb) { return GetRootAsFB_EternalTreasure(_bb, new FB_EternalTreasure()); }
  public static FB_EternalTreasure GetRootAsFB_EternalTreasure(ByteBuffer _bb, FB_EternalTreasure obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EternalTreasure __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Score { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Parm { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MDID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DicId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ShowItemId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Name { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ActivityId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FuntionOpenID { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UIID { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_EternalTreasure> CreateFB_EternalTreasure(FlatBufferBuilder builder,
      int ID = 0,
      int Score = 0,
      int Parm = -1,
      int MDID = -1,
      int DicId = -1,
      int ShowItemId = -1,
      StringOffset Name = default(StringOffset),
      int ActivityId = -1,
      int FuntionOpenID = -1,
      int UIID = -1) {
    builder.StartObject(10);
    FB_EternalTreasure.AddUIID(builder, UIID);
    FB_EternalTreasure.AddFuntionOpenID(builder, FuntionOpenID);
    FB_EternalTreasure.AddActivityId(builder, ActivityId);
    FB_EternalTreasure.AddName(builder, Name);
    FB_EternalTreasure.AddShowItemId(builder, ShowItemId);
    FB_EternalTreasure.AddDicId(builder, DicId);
    FB_EternalTreasure.AddMDID(builder, MDID);
    FB_EternalTreasure.AddParm(builder, Parm);
    FB_EternalTreasure.AddScore(builder, Score);
    FB_EternalTreasure.AddID(builder, ID);
    return FB_EternalTreasure.EndFB_EternalTreasure(builder);
  }

  public static void StartFB_EternalTreasure(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddScore(FlatBufferBuilder builder, int Score) { builder.AddInt(1, Score, 0); }
  public static void AddParm(FlatBufferBuilder builder, int Parm) { builder.AddInt(2, Parm, -1); }
  public static void AddMDID(FlatBufferBuilder builder, int MDID) { builder.AddInt(3, MDID, -1); }
  public static void AddDicId(FlatBufferBuilder builder, int DicId) { builder.AddInt(4, DicId, -1); }
  public static void AddShowItemId(FlatBufferBuilder builder, int ShowItemId) { builder.AddInt(5, ShowItemId, -1); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(6, NameOffset.Value, 0); }
  public static void AddActivityId(FlatBufferBuilder builder, int ActivityId) { builder.AddInt(7, ActivityId, -1); }
  public static void AddFuntionOpenID(FlatBufferBuilder builder, int FuntionOpenID) { builder.AddInt(8, FuntionOpenID, -1); }
  public static void AddUIID(FlatBufferBuilder builder, int UIID) { builder.AddInt(9, UIID, -1); }
  public static Offset<FB_EternalTreasure> EndFB_EternalTreasure(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EternalTreasure>(o);
  }
};

public sealed class FB_EternalTreasureContainer : Table {
  public static FB_EternalTreasureContainer GetRootAsFB_EternalTreasureContainer(ByteBuffer _bb) { return GetRootAsFB_EternalTreasureContainer(_bb, new FB_EternalTreasureContainer()); }
  public static FB_EternalTreasureContainer GetRootAsFB_EternalTreasureContainer(ByteBuffer _bb, FB_EternalTreasureContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EternalTreasureContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EternalTreasureContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EternalTreasure GetItems(int j) { return GetItems(new FB_EternalTreasure(), j); }
  public FB_EternalTreasure GetItems(FB_EternalTreasure obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EternalTreasureContainer> CreateFB_EternalTreasureContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EternalTreasureContainer.AddItems(builder, items);
    return FB_EternalTreasureContainer.EndFB_EternalTreasureContainer(builder);
  }

  public static void StartFB_EternalTreasureContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EternalTreasure>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EternalTreasureContainer> EndFB_EternalTreasureContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EternalTreasureContainer>(o);
  }
  public static void FinishFB_EternalTreasureContainerBuffer(FlatBufferBuilder builder, Offset<FB_EternalTreasureContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
