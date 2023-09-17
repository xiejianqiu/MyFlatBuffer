// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_AchievementClass : Table {
  public static FB_AchievementClass GetRootAsFB_AchievementClass(ByteBuffer _bb) { return GetRootAsFB_AchievementClass(_bb, new FB_AchievementClass()); }
  public static FB_AchievementClass GetRootAsFB_AchievementClass(ByteBuffer _bb, FB_AchievementClass obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_AchievementClass __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CountPoint { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Name { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetSubClassIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SubClassIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AchievementClass> CreateFB_AchievementClass(FlatBufferBuilder builder,
      int ID = 0,
      int CountPoint = -1,
      StringOffset Name = default(StringOffset),
      VectorOffset SubClassIDList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_AchievementClass.AddSubClassIDList(builder, SubClassIDList);
    FB_AchievementClass.AddName(builder, Name);
    FB_AchievementClass.AddCountPoint(builder, CountPoint);
    FB_AchievementClass.AddID(builder, ID);
    return FB_AchievementClass.EndFB_AchievementClass(builder);
  }

  public static void StartFB_AchievementClass(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCountPoint(FlatBufferBuilder builder, int CountPoint) { builder.AddInt(1, CountPoint, -1); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(2, NameOffset.Value, 0); }
  public static void AddSubClassIDList(FlatBufferBuilder builder, VectorOffset SubClassIDListOffset) { builder.AddOffset(3, SubClassIDListOffset.Value, 0); }
  public static VectorOffset CreateSubClassIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSubClassIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AchievementClass> EndFB_AchievementClass(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AchievementClass>(o);
  }
};

public sealed class FB_AchievementClassContainer : Table {
  public static FB_AchievementClassContainer GetRootAsFB_AchievementClassContainer(ByteBuffer _bb) { return GetRootAsFB_AchievementClassContainer(_bb, new FB_AchievementClassContainer()); }
  public static FB_AchievementClassContainer GetRootAsFB_AchievementClassContainer(ByteBuffer _bb, FB_AchievementClassContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_AchievementClassContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_AchievementClassContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_AchievementClass GetItems(int j) { return GetItems(new FB_AchievementClass(), j); }
  public FB_AchievementClass GetItems(FB_AchievementClass obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AchievementClassContainer> CreateFB_AchievementClassContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_AchievementClassContainer.AddItems(builder, items);
    return FB_AchievementClassContainer.EndFB_AchievementClassContainer(builder);
  }

  public static void StartFB_AchievementClassContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_AchievementClass>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AchievementClassContainer> EndFB_AchievementClassContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AchievementClassContainer>(o);
  }
  public static void FinishFB_AchievementClassContainerBuffer(FlatBufferBuilder builder, Offset<FB_AchievementClassContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
