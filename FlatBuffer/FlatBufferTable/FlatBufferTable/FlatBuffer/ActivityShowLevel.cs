// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActivityShowLevel : Table {
  public static FB_ActivityShowLevel GetRootAsFB_ActivityShowLevel(ByteBuffer _bb) { return GetRootAsFB_ActivityShowLevel(_bb, new FB_ActivityShowLevel()); }
  public static FB_ActivityShowLevel GetRootAsFB_ActivityShowLevel(ByteBuffer _bb, FB_ActivityShowLevel obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActivityShowLevel __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Level { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int Exp { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HpMax { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PMAttack { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PMDefence { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ActivityShowLevel> CreateFB_ActivityShowLevel(FlatBufferBuilder builder,
      int Id = 0,
      int Level = 1,
      int Exp = -1,
      int HpMax = -1,
      int PMAttack = -1,
      int PMDefence = -1) {
    builder.StartObject(6);
    FB_ActivityShowLevel.AddPMDefence(builder, PMDefence);
    FB_ActivityShowLevel.AddPMAttack(builder, PMAttack);
    FB_ActivityShowLevel.AddHpMax(builder, HpMax);
    FB_ActivityShowLevel.AddExp(builder, Exp);
    FB_ActivityShowLevel.AddLevel(builder, Level);
    FB_ActivityShowLevel.AddId(builder, Id);
    return FB_ActivityShowLevel.EndFB_ActivityShowLevel(builder);
  }

  public static void StartFB_ActivityShowLevel(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(1, Level, 1); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(2, Exp, -1); }
  public static void AddHpMax(FlatBufferBuilder builder, int HpMax) { builder.AddInt(3, HpMax, -1); }
  public static void AddPMAttack(FlatBufferBuilder builder, int PMAttack) { builder.AddInt(4, PMAttack, -1); }
  public static void AddPMDefence(FlatBufferBuilder builder, int PMDefence) { builder.AddInt(5, PMDefence, -1); }
  public static Offset<FB_ActivityShowLevel> EndFB_ActivityShowLevel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityShowLevel>(o);
  }
};

public sealed class FB_ActivityShowLevelContainer : Table {
  public static FB_ActivityShowLevelContainer GetRootAsFB_ActivityShowLevelContainer(ByteBuffer _bb) { return GetRootAsFB_ActivityShowLevelContainer(_bb, new FB_ActivityShowLevelContainer()); }
  public static FB_ActivityShowLevelContainer GetRootAsFB_ActivityShowLevelContainer(ByteBuffer _bb, FB_ActivityShowLevelContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActivityShowLevelContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActivityShowLevelContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActivityShowLevel GetItems(int j) { return GetItems(new FB_ActivityShowLevel(), j); }
  public FB_ActivityShowLevel GetItems(FB_ActivityShowLevel obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityShowLevelContainer> CreateFB_ActivityShowLevelContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActivityShowLevelContainer.AddItems(builder, items);
    return FB_ActivityShowLevelContainer.EndFB_ActivityShowLevelContainer(builder);
  }

  public static void StartFB_ActivityShowLevelContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActivityShowLevel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityShowLevelContainer> EndFB_ActivityShowLevelContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityShowLevelContainer>(o);
  }
  public static void FinishFB_ActivityShowLevelContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActivityShowLevelContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
