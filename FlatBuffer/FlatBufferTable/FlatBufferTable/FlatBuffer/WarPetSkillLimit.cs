// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WarPetSkillLimit : Table {
  public static FB_WarPetSkillLimit GetRootAsFB_WarPetSkillLimit(ByteBuffer _bb) { return GetRootAsFB_WarPetSkillLimit(_bb, new FB_WarPetSkillLimit()); }
  public static FB_WarPetSkillLimit GetRootAsFB_WarPetSkillLimit(ByteBuffer _bb, FB_WarPetSkillLimit obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WarPetSkillLimit __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LimitLevel { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_WarPetSkillLimit> CreateFB_WarPetSkillLimit(FlatBufferBuilder builder,
      int ID = 0,
      int LimitLevel = -1) {
    builder.StartObject(2);
    FB_WarPetSkillLimit.AddLimitLevel(builder, LimitLevel);
    FB_WarPetSkillLimit.AddID(builder, ID);
    return FB_WarPetSkillLimit.EndFB_WarPetSkillLimit(builder);
  }

  public static void StartFB_WarPetSkillLimit(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddLimitLevel(FlatBufferBuilder builder, int LimitLevel) { builder.AddInt(1, LimitLevel, -1); }
  public static Offset<FB_WarPetSkillLimit> EndFB_WarPetSkillLimit(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetSkillLimit>(o);
  }
};

public sealed class FB_WarPetSkillLimitContainer : Table {
  public static FB_WarPetSkillLimitContainer GetRootAsFB_WarPetSkillLimitContainer(ByteBuffer _bb) { return GetRootAsFB_WarPetSkillLimitContainer(_bb, new FB_WarPetSkillLimitContainer()); }
  public static FB_WarPetSkillLimitContainer GetRootAsFB_WarPetSkillLimitContainer(ByteBuffer _bb, FB_WarPetSkillLimitContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WarPetSkillLimitContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WarPetSkillLimitContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WarPetSkillLimit GetItems(int j) { return GetItems(new FB_WarPetSkillLimit(), j); }
  public FB_WarPetSkillLimit GetItems(FB_WarPetSkillLimit obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetSkillLimitContainer> CreateFB_WarPetSkillLimitContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WarPetSkillLimitContainer.AddItems(builder, items);
    return FB_WarPetSkillLimitContainer.EndFB_WarPetSkillLimitContainer(builder);
  }

  public static void StartFB_WarPetSkillLimitContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WarPetSkillLimit>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetSkillLimitContainer> EndFB_WarPetSkillLimitContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetSkillLimitContainer>(o);
  }
  public static void FinishFB_WarPetSkillLimitContainerBuffer(FlatBufferBuilder builder, Offset<FB_WarPetSkillLimitContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
