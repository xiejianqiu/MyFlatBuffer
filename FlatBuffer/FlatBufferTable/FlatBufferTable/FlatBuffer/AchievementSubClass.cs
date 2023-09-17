// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_AchievementSubClass : Table {
  public static FB_AchievementSubClass GetRootAsFB_AchievementSubClass(ByteBuffer _bb) { return GetRootAsFB_AchievementSubClass(_bb, new FB_AchievementSubClass()); }
  public static FB_AchievementSubClass GetRootAsFB_AchievementSubClass(ByteBuffer _bb, FB_AchievementSubClass obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_AchievementSubClass __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetAchievementIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AchievementIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AchievementSubClass> CreateFB_AchievementSubClass(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset AchievementIDList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_AchievementSubClass.AddAchievementIDList(builder, AchievementIDList);
    FB_AchievementSubClass.AddName(builder, Name);
    FB_AchievementSubClass.AddID(builder, ID);
    return FB_AchievementSubClass.EndFB_AchievementSubClass(builder);
  }

  public static void StartFB_AchievementSubClass(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddAchievementIDList(FlatBufferBuilder builder, VectorOffset AchievementIDListOffset) { builder.AddOffset(2, AchievementIDListOffset.Value, 0); }
  public static VectorOffset CreateAchievementIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAchievementIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AchievementSubClass> EndFB_AchievementSubClass(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AchievementSubClass>(o);
  }
};

public sealed class FB_AchievementSubClassContainer : Table {
  public static FB_AchievementSubClassContainer GetRootAsFB_AchievementSubClassContainer(ByteBuffer _bb) { return GetRootAsFB_AchievementSubClassContainer(_bb, new FB_AchievementSubClassContainer()); }
  public static FB_AchievementSubClassContainer GetRootAsFB_AchievementSubClassContainer(ByteBuffer _bb, FB_AchievementSubClassContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_AchievementSubClassContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_AchievementSubClassContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_AchievementSubClass GetItems(int j) { return GetItems(new FB_AchievementSubClass(), j); }
  public FB_AchievementSubClass GetItems(FB_AchievementSubClass obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AchievementSubClassContainer> CreateFB_AchievementSubClassContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_AchievementSubClassContainer.AddItems(builder, items);
    return FB_AchievementSubClassContainer.EndFB_AchievementSubClassContainer(builder);
  }

  public static void StartFB_AchievementSubClassContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_AchievementSubClass>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AchievementSubClassContainer> EndFB_AchievementSubClassContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AchievementSubClassContainer>(o);
  }
  public static void FinishFB_AchievementSubClassContainerBuffer(FlatBufferBuilder builder, Offset<FB_AchievementSubClassContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
