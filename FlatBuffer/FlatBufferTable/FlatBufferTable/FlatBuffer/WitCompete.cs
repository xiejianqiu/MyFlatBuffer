// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WitCompete : Table {
  public static FB_WitCompete GetRootAsFB_WitCompete(ByteBuffer _bb) { return GetRootAsFB_WitCompete(_bb, new FB_WitCompete()); }
  public static FB_WitCompete GetRootAsFB_WitCompete(ByteBuffer _bb, FB_WitCompete obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WitCompete __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int QuestionDic { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAnswerList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AnswerListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int CorrectANswer { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Money { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float Coefficient { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_WitCompete> CreateFB_WitCompete(FlatBufferBuilder builder,
      int ID = 0,
      int QuestionDic = -1,
      VectorOffset AnswerList = default(VectorOffset),
      int CorrectANswer = -1,
      int Money = -1,
      float Coefficient = 0) {
    builder.StartObject(6);
    FB_WitCompete.AddCoefficient(builder, Coefficient);
    FB_WitCompete.AddMoney(builder, Money);
    FB_WitCompete.AddCorrectANswer(builder, CorrectANswer);
    FB_WitCompete.AddAnswerList(builder, AnswerList);
    FB_WitCompete.AddQuestionDic(builder, QuestionDic);
    FB_WitCompete.AddID(builder, ID);
    return FB_WitCompete.EndFB_WitCompete(builder);
  }

  public static void StartFB_WitCompete(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddQuestionDic(FlatBufferBuilder builder, int QuestionDic) { builder.AddInt(1, QuestionDic, -1); }
  public static void AddAnswerList(FlatBufferBuilder builder, VectorOffset AnswerListOffset) { builder.AddOffset(2, AnswerListOffset.Value, 0); }
  public static VectorOffset CreateAnswerListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAnswerListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCorrectANswer(FlatBufferBuilder builder, int CorrectANswer) { builder.AddInt(3, CorrectANswer, -1); }
  public static void AddMoney(FlatBufferBuilder builder, int Money) { builder.AddInt(4, Money, -1); }
  public static void AddCoefficient(FlatBufferBuilder builder, float Coefficient) { builder.AddFloat(5, Coefficient, 0); }
  public static Offset<FB_WitCompete> EndFB_WitCompete(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WitCompete>(o);
  }
};

public sealed class FB_WitCompeteContainer : Table {
  public static FB_WitCompeteContainer GetRootAsFB_WitCompeteContainer(ByteBuffer _bb) { return GetRootAsFB_WitCompeteContainer(_bb, new FB_WitCompeteContainer()); }
  public static FB_WitCompeteContainer GetRootAsFB_WitCompeteContainer(ByteBuffer _bb, FB_WitCompeteContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WitCompeteContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WitCompeteContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WitCompete GetItems(int j) { return GetItems(new FB_WitCompete(), j); }
  public FB_WitCompete GetItems(FB_WitCompete obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WitCompeteContainer> CreateFB_WitCompeteContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WitCompeteContainer.AddItems(builder, items);
    return FB_WitCompeteContainer.EndFB_WitCompeteContainer(builder);
  }

  public static void StartFB_WitCompeteContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WitCompete>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WitCompeteContainer> EndFB_WitCompeteContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WitCompeteContainer>(o);
  }
  public static void FinishFB_WitCompeteContainerBuffer(FlatBufferBuilder builder, Offset<FB_WitCompeteContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
