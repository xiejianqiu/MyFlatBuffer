// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SkillCamAnim : Table {
  public static FB_SkillCamAnim GetRootAsFB_SkillCamAnim(ByteBuffer _bb) { return GetRootAsFB_SkillCamAnim(_bb, new FB_SkillCamAnim()); }
  public static FB_SkillCamAnim GetRootAsFB_SkillCamAnim(ByteBuffer _bb, FB_SkillCamAnim obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SkillCamAnim __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float TotalTime { get { int o = __offset(6); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float DelayTime { get { int o = __offset(8); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_SkillCamAnim> CreateFB_SkillCamAnim(FlatBufferBuilder builder,
      int Id = 0,
      float TotalTime = 0,
      float DelayTime = 0) {
    builder.StartObject(3);
    FB_SkillCamAnim.AddDelayTime(builder, DelayTime);
    FB_SkillCamAnim.AddTotalTime(builder, TotalTime);
    FB_SkillCamAnim.AddId(builder, Id);
    return FB_SkillCamAnim.EndFB_SkillCamAnim(builder);
  }

  public static void StartFB_SkillCamAnim(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddTotalTime(FlatBufferBuilder builder, float TotalTime) { builder.AddFloat(1, TotalTime, 0); }
  public static void AddDelayTime(FlatBufferBuilder builder, float DelayTime) { builder.AddFloat(2, DelayTime, 0); }
  public static Offset<FB_SkillCamAnim> EndFB_SkillCamAnim(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillCamAnim>(o);
  }
};

public sealed class FB_SkillCamAnimContainer : Table {
  public static FB_SkillCamAnimContainer GetRootAsFB_SkillCamAnimContainer(ByteBuffer _bb) { return GetRootAsFB_SkillCamAnimContainer(_bb, new FB_SkillCamAnimContainer()); }
  public static FB_SkillCamAnimContainer GetRootAsFB_SkillCamAnimContainer(ByteBuffer _bb, FB_SkillCamAnimContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SkillCamAnimContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SkillCamAnimContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SkillCamAnim GetItems(int j) { return GetItems(new FB_SkillCamAnim(), j); }
  public FB_SkillCamAnim GetItems(FB_SkillCamAnim obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SkillCamAnimContainer> CreateFB_SkillCamAnimContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SkillCamAnimContainer.AddItems(builder, items);
    return FB_SkillCamAnimContainer.EndFB_SkillCamAnimContainer(builder);
  }

  public static void StartFB_SkillCamAnimContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SkillCamAnim>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SkillCamAnimContainer> EndFB_SkillCamAnimContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillCamAnimContainer>(o);
  }
  public static void FinishFB_SkillCamAnimContainerBuffer(FlatBufferBuilder builder, Offset<FB_SkillCamAnimContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
