// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StarSoulLevel : Table {
  public static FB_StarSoulLevel GetRootAsFB_StarSoulLevel(ByteBuffer _bb) { return GetRootAsFB_StarSoulLevel(_bb, new FB_StarSoulLevel()); }
  public static FB_StarSoulLevel GetRootAsFB_StarSoulLevel(ByteBuffer _bb, FB_StarSoulLevel obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StarSoulLevel __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Exp { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AttackValue { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_StarSoulLevel> CreateFB_StarSoulLevel(FlatBufferBuilder builder,
      int ID = 0,
      int Exp = -1,
      int AttackValue = -1) {
    builder.StartObject(3);
    FB_StarSoulLevel.AddAttackValue(builder, AttackValue);
    FB_StarSoulLevel.AddExp(builder, Exp);
    FB_StarSoulLevel.AddID(builder, ID);
    return FB_StarSoulLevel.EndFB_StarSoulLevel(builder);
  }

  public static void StartFB_StarSoulLevel(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(1, Exp, -1); }
  public static void AddAttackValue(FlatBufferBuilder builder, int AttackValue) { builder.AddInt(2, AttackValue, -1); }
  public static Offset<FB_StarSoulLevel> EndFB_StarSoulLevel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarSoulLevel>(o);
  }
};

public sealed class FB_StarSoulLevelContainer : Table {
  public static FB_StarSoulLevelContainer GetRootAsFB_StarSoulLevelContainer(ByteBuffer _bb) { return GetRootAsFB_StarSoulLevelContainer(_bb, new FB_StarSoulLevelContainer()); }
  public static FB_StarSoulLevelContainer GetRootAsFB_StarSoulLevelContainer(ByteBuffer _bb, FB_StarSoulLevelContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StarSoulLevelContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StarSoulLevelContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StarSoulLevel GetItems(int j) { return GetItems(new FB_StarSoulLevel(), j); }
  public FB_StarSoulLevel GetItems(FB_StarSoulLevel obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarSoulLevelContainer> CreateFB_StarSoulLevelContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StarSoulLevelContainer.AddItems(builder, items);
    return FB_StarSoulLevelContainer.EndFB_StarSoulLevelContainer(builder);
  }

  public static void StartFB_StarSoulLevelContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StarSoulLevel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarSoulLevelContainer> EndFB_StarSoulLevelContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarSoulLevelContainer>(o);
  }
  public static void FinishFB_StarSoulLevelContainerBuffer(FlatBufferBuilder builder, Offset<FB_StarSoulLevelContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
